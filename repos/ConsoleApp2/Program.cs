/**
 * @author Mikey Dowsett
 * Get the lower and upper bound from the user.
 * Make sure they are correct
 * Either run the program again or show the sum.
 */
do {
    //Get the lower and upper bound until the are correct.
    Console.Write("Please enter a lower limit: ");
    int lowerBound = int.Parse(Console.ReadLine());

    Console.Write("Please enter an upper limit: ");
    int upperBound = int.Parse(Console.ReadLine());

    int sum = 0;

    //Check lower and upper are correct.
    if(lowerBound > upperBound) {
        Console.WriteLine();
        continue;
    } else {
        for(int i = lowerBound; i <= upperBound; i++) {
            sum += i;
        }
        //Display the sum
        Console.WriteLine($"The sum  from {lowerBound} " +
            $"to {upperBound} is {sum}");
        break;
    }
} while(true);