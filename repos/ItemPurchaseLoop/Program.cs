/**
* @author Mikey Dowsett
* Get the cost of the item.
* Get money from the user until their amount due is 0
* Tell them to take their item and take change if needed.
*/

//Get the cost of the item.
Console.Write("Vending machine item cost: $");
decimal amountDue = decimal.Parse(Console.ReadLine());
Console.Write("Please deposite money: $");
amountDue -= decimal.Parse(Console.ReadLine());

//Get more money until amount due is 0.
while(amountDue > 0) {
    Console.WriteLine($"\n{amountDue:C} still needed.");

    Console.Write("Please deposit money: $");
    decimal amountPayed = decimal.Parse(Console.ReadLine());
    if(amountPayed < 0) {
        continue;
    }
    amountDue -= amountPayed;
}

Console.WriteLine("\nPlease take your item.");
if(amountDue < 0) {
    Console.WriteLine($"Please take your change of {-amountDue:C}");
}