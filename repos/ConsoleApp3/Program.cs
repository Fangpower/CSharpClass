class Program {
    static void Main(string[] args) {
        DisplaySequence(4);
        DisplaySequence(5, 10);
        DisplaySequence(1, 10, 2);
        DisplaySequence(1, 7, 1.5);
    } // end Main 
    public static void DisplaySequence(int upper) {
        Console.WriteLine("DisplaySequence(int)");
        for (int i = 1; i <= upper; ++i)
            Console.Write(i + " ");
        Console.WriteLine();
    } // end DisplaySequence 
    public static void DisplaySequence(int lower, int upper) {
        Console.WriteLine("DisplaySequence(int, int)");
        for (int i = lower; i <= upper; ++i)
            Console.Write(i + " ");
        Console.WriteLine();
    } // end DisplaySequence 
    public static void DisplaySequence(double lower, double upper, double offset) {
        Console.WriteLine("DisplaySequence(double, double, double)"); for (double i = lower; i <= upper; i += offset)
            Console.Write(i + " ");
        Console.WriteLine();
    } // end DisplaySequence 
    /*public static void DisplaySequence(int lower, int upper, int offset) {
        Console.WriteLine("DisplaySequence(int, int, int)");
        for (int i = lower; i <= upper; i += offset)
            Console.Write(i + " ");
        Console.WriteLine();
    } // end DisplaySequence */
} // end class