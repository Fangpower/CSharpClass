/**
 * @author Mikey Dowsett
 * Class Program displays the initials for Kansas City
 * and also displays 5 of its suburbs.
 */
class Program {
    static void Main(string[] args) {
        //Display Kansas City's initials
        Console.WriteLine("*     *     *******");
        Console.WriteLine("*   *      *");
        Console.WriteLine("* *        *");
        Console.WriteLine("*          *");
        Console.WriteLine("* *        *");
        Console.WriteLine("*   *      *");
        Console.WriteLine("*     *     *******");

        //Display five of Kansas City's suburbs
        Console.Write("\nSuburb\t\t\tState"
            +"\nOverland Park\t\tKansas"
            +"\nOlathe\t\t\tKansas"
            +"\nRoeland Park\t\tKansas"
            +"\nLee's Summit\t\tMissouri"
            +"\nBelton\t\t\tMissouri");
    }
}