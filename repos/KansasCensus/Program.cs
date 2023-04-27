
using KansasCensus;
/**
* @author Mikey Dowsett
*/
class Program {
    public static void Main() {
        // Create an empty list of City objects named cities.
        List<City> cities = new List<City>();
        // Call ReadFile with the cities list
        ReadFile(cities);

        // Create/Execute Query 1:
        // Display the cities (with their populations) whose
        // names begin with the letter "O". The StartsWith method
        // of the string class is helpful here when defining
        // the query
        // Once you define the query, use a foreach
        // loop to display the cities with their populations.
        // Because you have already built the ToString method
        // for the City class this is easy to do.
        var citiesWith0 =
           from city in cities
           where city.Name.StartsWith('O')
           select city;
        Console.WriteLine("Cities beginning with O:");
        foreach(City city in citiesWith0) { 
            Console.WriteLine(city);
        }

        // Create/Execute Query 2:
        // Display the smallest 10 cities in Kansas with their populations
        // Utilize the orderby clause for the Population property and then
        // display the first 10 items using a for loop. You may hard code
        // in the number 10. In the for loop to display the cities, you can
        // utilize the ElementAt(index) extension method
        // e.g. Console.WriteLine(query2.ElementAt(i)); will display the
        // city at index i in the list
        var smallestCities = 
            from city in cities
            orderby city.Population
            select city;
        Console.WriteLine("\nSmallest 10 cities: ");
        for (int i = 0; i < 10; i++) {
            Console.WriteLine(smallestCities.ElementAt(i));
        }
        Console.WriteLine();
        // Create/Execute Query 3
        // Display the total population of Kansas with a heading
        // of "Total Population: ". Do this by writing a query to
        // select the Population for each item
        // You may then use the Sum() aggregate function: query3.Sum()
        // Use the query just defined and the Average()
        // aggregate function to display the average city size with
        // a precision of 2 and a heading of "Average City Size:"
        // Display the largest city in Kansas and its population with
        // a heading of "Largest City: "
        // This can be accomplished by utilizing a previous query that
        // ordered the cities in increasing order and applying the Last()
        // extension method to that query.
        // Alternatively, you could experiment by creating a new query that
        // orders the cities in descending order by population and applying
        // the First() extension method or ElementAt(0)
        var totalPopulation =
            from city in cities
            select city.Population;
        Console.WriteLine($"Total Population {totalPopulation.Sum():N0}");
        Console.WriteLine($"Average City Size: {totalPopulation.Average():N}");
        Console.WriteLine($"Largest City: {smallestCities.Last()}");
    } // end Main

    /**
    * ReadFile fills a list of items containing a city's
    * name and population. If an exception occurs opening
    * the file, the user is notified of the exception message
    * and the application exits with an error code of 1.
    * @precondition The input file is named KansasCensusCites.txt
    * and is contained in the Visual Studio project source file folder.
    * @param cities An empty List of City objects to fill.
    * e.g. List<City> cities */
    private static void ReadFile(List<City> cities) {
        StreamReader inFile = null;
        try {
            inFile = new StreamReader(new FileStream
                ("..//..//..//KansasCensusCities.txt", FileMode.Open));
        } catch(Exception ex) {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
        string record = inFile.ReadLine();
        while((record = inFile.ReadLine()) != null) {
            string[] data = record.Split(',');
            cities.Add(new City(data[0], int.Parse(data[1])));
        }
    }
} // end class
