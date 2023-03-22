/**
 * @author Mikey Dowsett
 * This program gets the user input for length and width.
 * It then makes sure length and width are proper.
 * Finally it outputs perimeter and area.
*/
// Get the length and width
Console.Write("Rectangle length: ");
int length = int.Parse(Console.ReadLine());
Console.Write("Rectangle width: ");
int width = int.Parse(Console.ReadLine());
Console.WriteLine();
//Checks for valid length and width
if (length <= 0) {
    Console.WriteLine("Improper length");
} else if(width <= 0) {
    Console.WriteLine("Improper Width");
} else {
    // Compute and display the perimeter and area
    int perimeter = 2 * (length + width);
    Console.WriteLine($"Perimeter: {perimeter:N} units");
    Console.WriteLine($"Area: {(length * width):N} sq units");
}