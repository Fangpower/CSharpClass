/**
 * @author Mikey Dowsett
 * Class Program displays simple mathematical 
 * calculations using two user-entered integers.
 */
class Program {
    static void Main(string[] args) {
        //Get the two integers
        Console.Write("First positive integer: ");
        int firstInteger = int.Parse(Console.ReadLine());
        Console.Write("Second positive integer: ");
        int secondInteger = int.Parse(Console.ReadLine());

        //Display results of simple mathematical calculations using the integers
        Console.WriteLine($"\nSum: {firstInteger + secondInteger:N0}"
            +$"\nProduct: {firstInteger * secondInteger:N0}"
            +$"\nDifference: {firstInteger - secondInteger:N0}"
            +$"\nQuotient: {(firstInteger / (double)secondInteger):N}"
            +$"\nRemainder: {firstInteger % secondInteger:N0}");
    }
}