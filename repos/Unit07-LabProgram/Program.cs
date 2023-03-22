/**
 * @author Mikey Dowsett
 * Class Program displays a random income and corresponding tax amount.
 */
namespace Unit07_LabProgram {
    internal class Program {
        const int MaxIncome = 600000;
        static Random rnd = new Random();

        static void Main(string[] args) {
            int randomIncome = rnd.Next(MaxIncome);
            int taxRate = GetIncomeTaxRate(randomIncome);
            Console.WriteLine($"Income tax rate for {randomIncome:C}: {taxRate}%");
            
        }

        /**
         * GetIncomeTaxRate determines the US federal income tax rate
         * for a given income.
         * @param income The income in US dollars
         * @precondition income >= 0
         * @return The tax rate
         */
        static int GetIncomeTaxRate(int income) {
            switch(income) {
                case <= 9875:
                    return 10;
                case <= 40125:
                    return 12;
                case <= 85525:
                    return 22;
                case <= 163300:
                    return 24;
                case <= 207350:
                    return 32;
                case <= 518400:
                    return 35;
                case >= 518401:
                    return 37;
            }
        }
    }
}