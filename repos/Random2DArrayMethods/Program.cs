/** 
 * Class Program generates, displays, and finds the 
 * the highest value in a table.
 * @author Mikey Dowsett */
class Program {
    public static void Main(String[] args) {
        int[,] table = GetFilledTable();
        ShowTable(table);
        int highRow, highCol;
        FindHighestLocation(table, out highRow, out highCol);

        // Display location of the highest
        Console.WriteLine("\nThe highest value located at " +
                        $"[{highRow},{highCol}] is {table[highRow, highCol]}.");

    } // end main


    /**
   * GetFilledTable creates and returns a 10 x 10 two dimensional
   * array filled with random integers in the range 0 - 99
   * @return The filled two-dimensional array. */
    static int[,] GetFilledTable() {
        Random generator = new Random();
        const int NUM_ROWS_COLS = 10;
        const int MAX_VALUE = 99;

        int[,] table = new int[NUM_ROWS_COLS, NUM_ROWS_COLS];

        for(int row = 0; row < table.GetLength(0); row++) {
            for(int col = 0; col < table.GetLength(0); col++) {
                table[row, col] = generator.Next(MAX_VALUE + 1);
            }
        }

        return table;
    }

    /**
   * ShowTable displays the values of a given two-dimensional array
   * of integers in a table format. Each value is right-aligned in a
   * field width of 3.
   * @param table The table of integers to display. */
    static void ShowTable(int[,] table) {
        for (int row = 0; row < table.GetLength(0); row++) {
            for (int col = 0; col < table.GetLength(0); col++) {
                Console.Write($"{table[row, col],3}");
            }
            Console.WriteLine();
        }
    }

    /**
  * FindHighestLocation finds the row and column indexes of the
  * highest value in the given two dimensional array.
  * @param table The two dimensional array for which to find 
  *              the highest value
  * @param highRow Will contain the row index of the highest value.
  * @param highCol Will contain the column index of the highest value. */
    static void FindHighestLocation(int[,] table, out int highRow, 
      out int highCol) {
        highRow = highCol = 0;
        int highValue = table[0, 0];

        for (int row = 0; row < table.GetLength(0); row++) {
            for (int col = 0; col < table.GetLength(0); col++) {
                if (table[row, col] > highValue) {
                    highValue = table[row, col];
                    highRow = row;
                    highCol = col;
                }
            }
        }
    }
}