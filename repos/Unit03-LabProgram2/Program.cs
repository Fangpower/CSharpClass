/**
 * @author Mikey Dowsett
 * Get the price and state until the user exits.
 * Display the tax for the state they choose
 * or tell them the state is not avaliable.
 */

string repeatTaxLoop = "Y";

//Continually retrieve prices and states until the user decides to exit.
do {
    //Get the pruchase price and state.
    Console.Write("Purchase price: $");
    decimal price = decimal.Parse(Console.ReadLine());

    //Check the price to make sure it's positive.
    if (price < 0) {
        Console.WriteLine("I'm sorry, please do not " +
            "enter a negative number.\n");
        continue;
    }

    Console.Write("Two letter abbreviation of state where purchased: ");
    string state = Console.ReadLine().ToUpper();

    //Display the corresponding sales tax.
    switch (state) {
        case "MO":
            Console.WriteLine($"Sales Tax {(price * 0.04225m):C}");
            break;
        case "KS":
            Console.WriteLine($"Sales Tax {(price * 0.065m):C}");
            break;
        case "NE":
            Console.WriteLine($"Sales Tax {(price * 0.055m):C}");
            break;
        case "IA":
            Console.WriteLine($"Sales Tax {(price * 0.06m):C}");
            break;
        default:
            Console.WriteLine("I'm sorry, that state " +
                "is not in our system.");
            break;
    }
    //Get another price?
    Console.Write("\nEnter another price (Y or N)? ");
    repeatTaxLoop = Console.ReadLine().ToUpper();

} while (repeatTaxLoop == "Y");