/**@author Mikey Dowsett*/
public class Program {
    public static void Main() {
        // Test default house constructor
        Console.WriteLine("Default house:");
        House defaultHouse = new House();
        Console.WriteLine(defaultHouse);
        // Test adjustment of properties
        Console.WriteLine("\nAdjust house properties:");
        defaultHouse.SquareFeet = 3000;
        defaultHouse.NumFloors = 2;
        defaultHouse.NumBedrooms = 4;
        Console.WriteLine(defaultHouse);
        // Test adjustment to negative properties
        Console.WriteLine("\nAttempt adjustment to invalid data:");
        defaultHouse.SquareFeet = -3000;
        defaultHouse.NumFloors = -2;
        defaultHouse.NumBedrooms = -4;
        Console.WriteLine(defaultHouse);
        // Test constructor that takes all parameters
        Console.WriteLine("\nBuild house with constructor that takes" +
        " 3 parameters.");
        House newHouse = new House(2500, 1, 3);
        Console.WriteLine(newHouse);
        // Test constructor with invalid parameters
        Console.WriteLine("\nTest constructor with negative parameters.");
        House badHouse = new House(-2500, -1, -3);
        Console.WriteLine(badHouse);
    }
}