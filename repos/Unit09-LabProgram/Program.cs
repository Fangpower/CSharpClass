/**
 * @author Mikey Dowsett
 * Class Program finds the date of the highest price as well
 * as the average price for a simple file of mutual fund data.
 * A summary file is created with this data. 
 */
internal class Program {
    public static void Main() // MAIN MAY NOT BE CHANGED
    {
        string highDate = "";
        decimal highPrice = 0;
        decimal avgPrice = 0;

        ReadStockData(ref highDate, ref highPrice, ref avgPrice);
        WriteStockSummary(highDate, highPrice, avgPrice);
        Console.WriteLine("Data processing complete.");
    } // end Main

    /**
     * ReadStockData reads stock prices and dates from a file and determines
     * the highest closing price, the date of the highest closing price, and
     * the average closing price.
     * @precondition The input file is named PriceHistory.txt and is contained
     * in the source code folder for this project. The file contains at least
     * one record.
     * @param highDate Will contain the date of the highest closing price.
     * @param highPrice Will contain the highest closing price.
     * @param avgPrice Will contain the average closing price. */
    static void ReadStockData(ref string highDate, ref decimal highPrice, ref decimal avgPrice) {
        StreamReader priceHistoryFile = null;
        Console.Write("Input the file name: ");
        string fileName = Console.ReadLine();

        try {
            priceHistoryFile = new StreamReader(new FileStream($"..\\..\\..\\{fileName}", FileMode.Open));
        } catch (FileNotFoundException ex){
            Console.WriteLine($"There was an error: {ex.Message}");
            Environment.Exit(1);
        }
        
        string record = "";
        int count = 0;
        while((record = priceHistoryFile.ReadLine()) != null){
            //Split the record into the date and price
            string[] contents = record.Split(',');
            decimal price = decimal.Parse(contents[1]);

            //Check if the current price is higher.
            if (price > highPrice) {
                highPrice = price;
                highDate = contents[0];
            }

            avgPrice += price;
            count++;
        }
        avgPrice /= count;
        priceHistoryFile.Close();
    }

    /**
     * WriteStockSummary writes a file named PriceSummary.txt to the
     * project's source file folder. The format is:
     * highDate highPrice
     * avgPrice
     * Each price will ensure a $, commas if needed, and 2 digits of 
     * precision.
     * @param highDate Contains the date of the highest closing price.
     * @param highPrice Contains the highest closing price.
     * @param avgPrice Contains the average closing price. */
    static void WriteStockSummary(string highDate, decimal highPrice, decimal avgPrice) {
        //Creates a new file to store the information about the price history file
        StreamWriter newFile = new StreamWriter(new FileStream("..\\..\\..\\PriceSummary.txt", FileMode.Create));
        newFile.WriteLine($"{highDate} {highPrice:C}\n{avgPrice:C}");
        newFile.Close();
    }
}