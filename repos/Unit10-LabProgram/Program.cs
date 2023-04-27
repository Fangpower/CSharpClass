using System;
using System.IO;
/**
 * @author Mikey Dowsett
 * Class Program processes baseball player last names and hits
 * from a comma delimited data file.
 */
class Program {
    static void Main(string[] args) {
        const int MAX_PLAYERS = 100;

        // ADD CODE
        // Declare an array named lastNames that will hold up to
        // MAX_PLAYERS names
        string[] lastNames = new string[MAX_PLAYERS];

        // ADD CODE
        // Declare an array named hits that will hold up to
        // MAX_PLAYERS hits (integers)
        int[] hits = new int[MAX_PLAYERS];

        int numPlayers = GetPlayerStats("PlayerStats.txt", lastNames, hits);

        // Display the total hits
        Console.WriteLine($"Total Hits: {GetTotalHits(hits, numPlayers):N0}");

        // Attempt to insert a new player
        Console.Write("Last name of new player? ");
        string playerLastName = Console.ReadLine();
        Console.Write($"Number of hits for {playerLastName}? ");
        int numHits = int.Parse(Console.ReadLine());
        int insertionIndex = FindPlayer(lastNames, playerLastName, numPlayers);
        if (insertionIndex >= 0)
            Console.WriteLine($"{playerLastName} already exists. ");
        else {
            // ADD CODE
            // At this point we know that insertionIndex is negative.
            // Thus, look at the notes to use one line of code to transform 
            // insertionIndex into a value where the insertion is to take place.
            // Then, write one loop that shifts values to the right to
            // make room. You will need to shift the data in both
            // the lastNames and the hits array inside the loop.
            // After the loop insert the player last name into the lastNames
            // array at the insertionIndex. Do the same for the hits
            // Finally, increment the number of players.
            insertionIndex = Math.Abs(insertionIndex) - 1;
            for(int i = numPlayers; i >= insertionIndex; i--) {
                lastNames[i + 1] = lastNames[i];
                hits[i + 1] = hits[i];
            }
            lastNames[insertionIndex] = playerLastName;
            hits[insertionIndex] = numHits;
            numPlayers++;

        } // end else

        Console.WriteLine("Players, Hits  (Sorted by last names)");
        for (int i = 0; i < numPlayers; ++i)
            Console.WriteLine($"{lastNames[i]}, {hits[i]}");

        // Sort by hits
        SortByHits(lastNames, hits, numPlayers);
        Console.WriteLine("\nPlayers, Hits  (Sorted by hits)");
        for (int i = 0; i < numPlayers; ++i)
            Console.WriteLine($"{lastNames[i]}, {hits[i]}");

    } // end Main

    /**
	 * GetPlayerStats reads player last names, at bats, and hits
	 * from a given file and stores the data in a parallel manner into 
	 * the given arrays.
	 * @param fileName The name of the file containing the statistics
	 * @param lastNames An array that will hold the player last names
	 * @param hits An array that will hold the player weights
	 * @precondition The arrays contain enough elements to hold the number
	 * of players read.
	 * @return The number of players read from the file. */
    static int GetPlayerStats(string fileName, String[] lastNames,
        int[] hits) {
        // Open the input file (COMPLETED)
        StreamReader inFile = null;
        try {
            inFile = new StreamReader(
                new FileStream("..\\..\\..\\" + fileName, FileMode.Open));
        } catch (Exception exc) {
            Console.WriteLine("File open error: " + exc.Message);
            Environment.Exit(1);
        }

        // Skip the header (COMPLETED)
        inFile.ReadLine();

        // ADD CODE
        // Write code to read in the players last names and hits into
        // the lastNames and hits arrays. This is similar to the lab with
        // stock prices. You will need to use split like the example with
        // comma delimiters in the notes, except now split will return an
        // array of data of size 5 instead of 2. You will need the data 
        // at index 0 (last names) and the data at index 3 (hits)
        // Close the file when finished. Also, keep track of how many 
        // players are read and return that value
        string record = "";
        int players = 0;
        while((record = inFile.ReadLine()) != null) {
            string[] data = record.Split(",");
            lastNames[players] = data[0];
            hits[players] = int.Parse(data[3]);
            players++;
        }
        inFile.Close();
        return players;
    } // end method

    /**
	 * GetTotalHits totals up all the hits for the players
	 * @param hits An array of player hits
	 * @param numPlayers The number of players
	 * @return The total hits */
    static int GetTotalHits(int[] hits, int numPlayers) {
        // ADD CODE
        int totalHits = 0;
        for(int i = 0; i < numPlayers; i++) {
            totalHits += hits[i];
        }

        return totalHits; // Replace 0 with the variable for the total hits
    } // end method

    /** 
	* FindPlayer searches for the index of lastName in lastNames
	* @param lastNames The last names of the players
	* @param lastName The last name for which to search
	* @param numPlayers The number of last names in the array
	* @precondition The lastNames array is in ascending alphabetic order
	* @return the index of the found last name or a negative index
	* indicating where the name can be inserted. */
    static int FindPlayer(string[] lastNames, string lastName, int numPlayers) {
        // ADD CODE
        int low = 0; 
        int high = numPlayers - 1;
        while (high >= low) {
            int mid = (low + high) / 2; 
            if (String.Compare(lastName, lastNames[mid]) > 0) 
                low = mid + 1; 
            else if (String.Compare(lastName, lastNames[mid]) < 0) 
                high = mid - 1; 
            else return mid; // key found
        }
        return -low - 1;
    } // end method

    /**
	 * SortByHits will sort data in the arrays according to the player hits
	 * @param lastNames An array of player last names
	 * @param hits An array of player hits
	 * @param numPlayers The number of players */
    static void SortByHits(string[] lastNames,
        int[] hits, int numPlayers) {
        // ADD CODE
        for (int i = 0; i < numPlayers; i++) {
            int indexSmallest = i;
            for (int j = i + 1; j < numPlayers; j++) {
                if (hits[j] < hits[indexSmallest])
                    indexSmallest = j;
            }

            if (indexSmallest != i) {
                //Swap the first name
                int tmp = hits[i];
                hits[i] = hits[indexSmallest];
                hits[indexSmallest] = tmp;
                //Swap the last name
                string tmpString = lastNames[i];
                lastNames[i] = lastNames[indexSmallest];
                lastNames[indexSmallest] = tmpString;
            }
        }
    }
} //end class