using SodaInheritance;
/** @author Mikey Dowsett */
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Check parameterless constructor");
        Item defaultItem = new Item();
        Soda defaultSoda = new Soda();
        Console.WriteLine(defaultItem);
        Console.WriteLine(defaultSoda);

        Console.WriteLine("\nCheck constructor with invalid paremters");
        Soda aSoda = new Soda("Pepsi", -1.25M, -8, -16);
        Item ball = new Item("Ball", -19.99M, -10);
        Console.WriteLine(ball);
        Console.WriteLine(aSoda);

        Console.WriteLine("\nCheck constructor with valid parameters");
        aSoda = new Soda("Pepsi", 1.25M, 8, 16);
        ball = new Item("Ball", 19.99M, 10);
        Console.WriteLine(ball);
        Console.WriteLine(aSoda);

        Console.WriteLine("\nCheck setting properties with invalid values");
        aSoda.Name = "Mtn Dew";
        aSoda.Price = -1.5M;
        aSoda.Quantity = -10;
        aSoda.Ounces = -12;
        Console.WriteLine(aSoda);

        Console.WriteLine("\nCheck setting properties with valid values");
        aSoda.Price = 1.5M;
        aSoda.Quantity = 10;
        aSoda.Ounces = 12;
        Console.WriteLine(aSoda);

        Console.WriteLine("\nCheck different types of reduction");
        aSoda.Reduce(-2);
        Console.WriteLine(aSoda);
        aSoda.Reduce(12);
        Console.WriteLine(aSoda);
        aSoda.Reduce(2);
        Console.WriteLine(aSoda);
        aSoda.Reduce(8);
        Console.WriteLine(aSoda);
    }
}