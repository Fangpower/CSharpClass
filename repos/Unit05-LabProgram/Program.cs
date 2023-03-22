/**
*@author Mikey Dowsett
*This program tests the rectangle class.
*/
class Program {
    public static void Main() {
        Rectangle aRectangle = new Rectangle(3, 4);


        // Display the rectangle dimensions 
        Console.WriteLine($"Length: {aRectangle.Length}, " +
            $"Width: {aRectangle.Width}");

        // Test that negative values are ignored 
        aRectangle.Length = -2;
        aRectangle.Width = -4;
        Console.WriteLine($"Length: {aRectangle.Length}, " +
            $"Width: {aRectangle.Width}");

        Rectangle badRectangle = new Rectangle(-3, -4);

        // Display the rectangle dimensions 
        Console.WriteLine($"\nLength: {badRectangle.Length}, " +
        $"Width: {badRectangle.Width}");

        // Test that valid values may be set 
        aRectangle.Length = 2;
        aRectangle.Width = 4;
        Console.WriteLine($"Length: {aRectangle.Length}, " +
            $"Width: {aRectangle.Width}");
    }
}