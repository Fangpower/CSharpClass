/**
 * @author Mikey Dowsett
 * Get wind speed from user and display severity level.
 * Ask the user if they want to repeat the program.
 */

const int HIGH_WIND = 180;
const int LOW_WIND = 73;
int windSpeed;
string again = "Y";
while (again.Equals("Y")) {
    //Get wind speed.
    do {
        Console.Write($"Wind Speed (MPH <= {HIGH_WIND} and >= {LOW_WIND}): ");
        windSpeed = int.Parse(Console.ReadLine());
    } while (windSpeed > HIGH_WIND || windSpeed < LOW_WIND);

    //Display wind damage.
    if (windSpeed >= 74 && windSpeed <= 95) {
        Console.WriteLine("Very dangerous winds will produce some damage.");
    } else if (windSpeed >= 96 && windSpeed <= 110) {
        Console.WriteLine("Extremely dangerous winds will cause " +
            "extensive damage.");
    } else if (windSpeed >= 111 && windSpeed <= 129) {
        Console.WriteLine("Devastating damage will occur.");
    } else if (windSpeed >= 130 && windSpeed <= 156) {
        Console.WriteLine("Catastrophic damage will occur.");
    } else if (windSpeed >= 157) {
        Console.WriteLine("Catastrophic damage will occur. " +
            "A high percentage of framed homes will be destroyed.");
    } else {
        Console.WriteLine("Not a hurricane");
    }
    Console.Write("\nDo you want to run the program again? Y/N: ");
    again = Console.ReadLine().ToUpper();
}