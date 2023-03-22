/**
 * @author Mikey Dowsett
 * Class Program will compute a temprature with the windchill factored in.
 */
namespace Windchill_Computation {
    internal class Program {
        static void Main(string[] args) {
            //Get a valid temprature <= 50
            const int HIGH_TEMP = 50;
            int temp;
            do {
                Console.Write("Enter a Fahrenheit temprature less than or equal " +
                    $"to {HIGH_TEMP}: ");
                temp = int.Parse(Console.ReadLine());
            } while (temp > HIGH_TEMP);

            //Get a valid wind speed > 3
            const int LOW_WIND = 3;
            int windSpeed;
            do {
                Console.Write($"Enter a wind speed in MPH > {LOW_WIND}: ");
                windSpeed = int.Parse(Console.ReadLine());
            } while (windSpeed <= LOW_WIND);

            //Compute the windchill
            Console.WriteLine("\nWindchill Temperature: " +
                $"{ComputeWindchill(temp, windSpeed):N1} degrees Fahrenheit.");
        }

        /**
         * ComputeWindchill determines the windchill temperature given a
         * temperature and wind speed.
         * @param temperature The temperature in degress Fahrenheit
         * @param windSpeed The wind speed in MPH
         * @precondition temperature <= 50, windSpeed > 3
         * @return the computed windchill in degrees Fahrenheit
         */
        static double ComputeWindchill(int temperature, int windSpeed) {
            double windChill = 35.74 + 0.6215 * temperature - 
                35.75 * Math.Pow(windSpeed, 0.16) + 
                0.4275 * temperature * Math.Pow(windSpeed, 0.16);
            return windChill;
        }
    }
}