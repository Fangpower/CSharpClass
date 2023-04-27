/**@author Mikey Dowsett */
public class Program {
    public static void Main() {
        // Create a new default building object assigned to a
        // variable named building1
        Building building1 = new Building();

        // Create a new building object of 3000 square feet
        // assigned to a variable named building2
        Building building2 = new Building(3000);

        // Display building1 and building2 (uncomment next line)
        Console.WriteLine($"Building1: {building1}\nBuilding2: {building2}");

        // Increase the square footage of building1 by using the ++ operator
        building1++;

        // Display building1 -- uncomment the next line
        Console.WriteLine($"Building1 increamented: {building1}");

        // If building1 is larger than building2, display "Building1 larger"
        // else if building2 is larger, display "Building2 larger"
        // else display "Buildings the same size"
        if (building1.CompareTo(building2) > 0)
            Console.WriteLine("Building1 larger");
        else if (building1.CompareTo(building2) < 0)
            Console.WriteLine("Building2 larger");
        else
            Console.WriteLine("Buildings the same size");

        // Create a new default house object assigned to a
        // variable named house1
        House house1 = new House();

        // Create a new house object of 2000 square feet and 3 bedrooms
        // assigned to a variable named house2
        House house2 = new House(2000, 3);

        // Use an object initializer to create new house object of 4 bedrooms
        // assigned to a variable named house3
        House house3 = new House { NumBedrooms = 4 };

        // Display house1, house2, and house3 -- uncomment the following line
        Console.WriteLine($"\nHouse1: {house1}\nHouse2: {house2}" +
         $"\nHouse3: {house3}");

        // Uncomment the following lines
        house1.SquareFeet = 2500;
        house1.NumBedrooms = 4;
        Console.WriteLine($"\nHouse1 adjusted: {house1}");

        Console.Write("\nHouse1 < House2? ");
        // Display the returned result by using < to compare house1 and house2
        Console.WriteLine(house1 < house2);

        Console.Write("House1 > House2? ");
        // Display the returned result by using > to compare house1 and house2
        Console.WriteLine(house1 > house2);

        Console.WriteLine("\nBig House: house1 + house2");
        // Assign to a new House variable named bigHouse the sum of house1
        // and house2
        House bigHouse = house1 + house2;

        // Display bigHouse by uncommenting the following code
        Console.WriteLine(bigHouse);

        Console.WriteLine("\nBig House doubled twice:");
        // Use method chaining to call DoubleSize() on bigHouse twice
        bigHouse.DoubleSize().DoubleSize();

        // Display bigHouse by uncommenting the following code
        Console.WriteLine(bigHouse);

        // Uncomment the following lines of code
        List<Building> buildings = new List<Building>();
        buildings.Add(new Building(5000));
        buildings.Add(new Building(1000));
        buildings.Add(new Building(2500));
        buildings.Add(new Building(1000));
        buildings.Add(new Building(4500));

        // Sort the buildings list
        buildings.Sort();

        Console.WriteLine();
        // Use a loop to display the buildings on separate lines
        foreach (Building building in buildings)
            Console.WriteLine(building);
    } // end Main
} // end class