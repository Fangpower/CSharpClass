/**
 * @author Mikey Dowsett
 * Class Program calculates a factorial.
 */
public class Program {
    public static void Main() {
        Console.Write("Which factorial to compute? ");
        int facLimit = Convert.ToInt32(Console.ReadLine());

        try {
            Console.WriteLine($"{facLimit}! = {Factorial(facLimit)}");
        } catch (Exception ex) {
            Console.WriteLine($"Error: {ex.Message}");
            Environment.Exit(1);
        }
    } // end Main

    /** Factorial computes the factorial of a given number
     * @param facLimit The factorial to compute
     * @precondition facLimit >= 1
     * @throws Exception Factorial not >= 1
     * @return facLimit!*/
    public static long Factorial(int facLimit) {
        if(facLimit < 1)
            throw new Exception($"{facLimit} not >= 1");

        if (facLimit == 1) // base case
            return 1;
        else
            return facLimit * Factorial(facLimit - 1);
    } // end Factorial
}