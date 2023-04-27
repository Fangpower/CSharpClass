/**
 * @author Mikey Dowsett
 */
class Program {
    static void Main(string[] args) {
        const int TWENTY = 20;
        const int FIFITY = 50;

        Random random = new Random();
        int[] data = new int[TWENTY];

        for (int i = 0; i < TWENTY; i++) {
            data[i] = (int)random.Next(-FIFITY, FIFITY + 1);
        }

        DisplayData(data);
        Console.WriteLine($"The lowest array value is {FindLowest(data)}.");
    }

    static void DisplayData(int[] data) {
        for (int i = 0; i < data.Length; i++) {
            Console.Write($"{data[i]} ");
        }
        Console.WriteLine();
    }

    static int FindLowest(int[] data) {
        int lowest = data[0];
        for (int i = 1; i < data.Length; i++) {
            if (data[i] < lowest) {
                lowest = data[i];
            }
        }
        return lowest;
    }
}