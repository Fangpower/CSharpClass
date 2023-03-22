/**
 * @author Mikey Dowsett
 * Get the radius and ensure it's valid.
 * Get the users choice and display
 * surface area, volume, or an error message.
 */

//Get the radius
Console.Write("Enter the radius (feet): ");
double radius = double.Parse(Console.ReadLine());

//Ensure the radius is valid
if(radius > 0) {
    //Get the user choice
    Console.Write("Enter S (Surface Area) or V (Volume): ");
    string choice = Console.ReadLine().ToUpper();

    //Display the surface area, volume, or an error message
    if (choice.Equals("S")) {
        Console.WriteLine($"Surface area: " +
            $"{(4.0 * Math.PI * Math.Pow(radius, 2)):N3} square feet.");
    } else if(choice.Equals("V")) {
        Console.WriteLine($"Volume: " +
            $"{(4.0/3.0 * Math.PI * Math.Pow(radius, 3)):N3} cubic feet.");
    } else {
        Console.WriteLine("I'm sorry, I did not understand your choice.");
    }
} else {
    Console.WriteLine("I'm sorry, an invalid radius was entered.");
}