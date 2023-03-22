/**
 * @author Mikey Dowsett
 * Display multiplication table based on users input for row and column
 */

const int MAX_ROWS_COLS = 15;
int numRows = 0;
int numCols = 0;

//Get a valid row and column number
do {
    Console.Write($"Enter # of rows (1 <= # <= {MAX_ROWS_COLS:D}): ");
    numRows = int.Parse(Console.ReadLine());
    Console.Write($"Enter # of cols (1 <= # <= {MAX_ROWS_COLS:D}): ");
    numCols= int.Parse(Console.ReadLine());

    Console.WriteLine();
} while (numRows < 1 || numCols < 1 || 
    numRows > MAX_ROWS_COLS || numCols > MAX_ROWS_COLS);

//Display the table
for(int x = 1; x <= numRows; ++x) {
    for(int y = 1; y <= numCols; ++y) {
        Console.Write($"{x * y, -4}");
    }
    Console.WriteLine();
}