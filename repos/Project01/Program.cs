/**
* @author Mikey Dowsett
* This program creates a banking loop for the user to interact with.
* They can withdraw, deposit, view their balance, and exit.
*/

decimal balance = 1000;
string choice = "";
//Loop through options until the user exits.
do {
    Console.Write("Enter W for Widthdraw\n" +
        "Enter D for Deposit\nEnter B for Balance\n" +
        "Enter E for Exit\nChoice: ");
    choice = Console.ReadLine().ToUpper();

    //Output correct response based on user inputs.
    switch(choice) {
        //Case to withdraw money
        case "W":
            Console.Write("Enter amount to withdraw: $");
            decimal  withdrawAm = decimal.Parse(Console.ReadLine());
            if (withdrawAm <= 0)
                Console.WriteLine("Improper widthdraw amount entered.");
            else if(withdrawAm > balance)
                Console.WriteLine("Insufficient funds.");
            else {
                Console.WriteLine($"Please take your {withdrawAm:C}");
                balance -= withdrawAm;
            }
            break;
        //Case to deposit money
        case "D":
            Console.Write("Enter amount to deposit: $");
            decimal depositAm = decimal.Parse(Console.ReadLine());
            if (depositAm <= 0)
                Console.WriteLine("Improper deposit amount entered.");
            else {
                Console.WriteLine($"{depositAm:C} added to your account.");
                balance += depositAm;
            }
            break;
        //Case to show balance
        case "B":
            Console.WriteLine($"Current balance: {balance:C}");
            break;
        //Case to exit the loop
        case "E":
            Console.WriteLine("Thank you for banking with us!");
            break;
        //Default if user inputs unrecognized character.
        default:
            Console.WriteLine("Choice not recognized.");
            break;
    }

    Console.WriteLine();
} while(choice != "E");