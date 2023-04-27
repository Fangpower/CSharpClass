/**
 * Class Program displays information for a desired Kansas county.
 * @author Mikey Dowsett
 */
class Program {
    public static void Main() {
        County[] counties = null;
        try {
            counties = ReadCountyData("KansasCountyData.txt");
        } catch (Exception exc) {
            Console.WriteLine(exc.Message);
            return;
        }
        Console.Write("County to find? ");
        Console.WriteLine(FindCountyData(counties, Console.ReadLine()));
    } // end Main

    /**
	* ReadCountyData reads data for the Kansas counties
	* @param fileName The name of the file that contains the data
	* @precondition The file is in the Visual Studio source code folder
	* for your Visual Studio project
	* @return An array containing Kansas counties */
    public static County[] ReadCountyData(string fileName) {
        const int NUM_COUNTIES = 105;

        // Allocate an array of County objects named counties
        // that holds NUM_COUNTIES counties
        // Note: The array data type is County (Not String)
        County[] counties = new County[NUM_COUNTIES];

        // Open the file for reading from your project's source code folder
        // No try-catch needed because of the try-catch in Main
        StreamReader inFile = new StreamReader(new FileStream("..\\..\\..\\KansasCountyData.txt", FileMode.Open));

        // Read and ignore the first line of the file which is the header
        // Note: You can just call ReadLine() and not even store the
        // returned value.
        inFile.ReadLine();

        // Use a for loop to read NUM_COUNTIES counties and store County
        // objects into the counties array. In each loop iteration, after
        // reading the line and splitting out the county name, seat, and 
        // population, assign a 'new' County object containing the name,
        // seat, and population into the current array slot. For full 
        // credit to be given, the County constructor must be called directly
        // with the three values (county name, seat, population) just read.
        string record = "";
        int countyNum = 0;
        while((record = inFile.ReadLine()) != null) {
            string[] data = record.Split(',');
            counties[countyNum] = new County(data[0], data[1], int.Parse(data[2]));
            countyNum++;
        }

        // Close the file
        inFile.Close();
        // Return the counties array (only the name is needed, no brackets)
        return counties;
    }

    /**
	* FindCountyData searches for the given county and returns
	* corresponding information
	* @param counties An array of data for the counties
	* @param countyName The name of the county to find
	* @return The string representation of the county or else
	*         a string containing "No county found" */
    public static string FindCountyData(County[] counties, string countyName) {
        int low = 0;
        int high = counties.Length - 1;

        while (high >= low) {
            int mid = (low + high) / 2;
            if (String.Compare(countyName.ToLower(), 
                counties[mid].Name.ToLower()) > 0)
                low = mid + 1;
            else if (String.Compare(countyName.ToLower(), 
                counties[mid].Name.ToLower()) < 0)
                high = mid - 1;
            else
                return counties[mid].ToString(); // key found
        }
        return "No county found.";
    } // end method

} // end class
