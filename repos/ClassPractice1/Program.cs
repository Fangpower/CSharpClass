/**
* @author Mikey Dowsett
* This program is a test driver for the Invoice class. */
// Call the constructor to instantiate a new invoice named myInvoice with a
// part number of "12-345", a description of "Key chain", 10 in stock, and a
// price of $1.95
Invoice myInvoice = new Invoice("12-345", "Key chain", 10, 1.95m);
// Call the constructor to instantiate a new invoice named badInvoice with a
// part number of "10-678", a description of "Hub cap", 10 in stock, and a
// price of negative $45
Invoice badInvoice = new Invoice("10-678", "Hub cap", 10, -45m);
// Display invoice information

Console.WriteLine("Testing: 12-345, Key chain, 10, 1.95");
Console.WriteLine($"Part Number: {myInvoice.PartNumber}\n" +
                $"Description: {myInvoice.PartDescription}\n" +
                $"Quantity: {myInvoice.Quantity}\n" +
                $"Price: {myInvoice.PricePerItem:C}\n" +
                $"Amount: {myInvoice.GetInvoiceAmount():C}");
Console.WriteLine("\nTesting: 10-678, Hub cap, 10, -45M");
Console.WriteLine($"Part Number: {badInvoice.PartNumber}\n" +
                $"Description: {badInvoice.PartDescription}\n" +
                $"Quantity: {badInvoice.Quantity}\n" +
                $"Price: {badInvoice.PricePerItem:C}\n" +
                $"Amount: {badInvoice.GetInvoiceAmount():C}");

// Test invalid data
Console.WriteLine("\nTesting price change to -1.50 and quantity to -5.");
myInvoice.PricePerItem = -1.50M;
myInvoice.Quantity = -5;

// Display Invoice Information
Console.WriteLine($"Part Number: {myInvoice.PartNumber}\n" +
                $"Description: {myInvoice.PartDescription}\n" +
                $"Quantity: {myInvoice.Quantity}\n" +
                $"Price: {myInvoice.PricePerItem:C}\n" +
                $"Amount: {myInvoice.GetInvoiceAmount():C}");

// Adjust data
myInvoice.PartNumber = "23-456";
myInvoice.PartDescription = "Air Filter";
myInvoice.Quantity = 12;
myInvoice.PricePerItem = 10.50M;

// Display invoice information
Console.WriteLine("\nTesting valid adjustment of object properties: " +
"\n23-456, Furnace Filter, 12, 1.50");
Console.WriteLine($"Part Number: {myInvoice.PartNumber}\n" +
                $"Description: {myInvoice.PartDescription}\n" +
                $"Quantity: {myInvoice.Quantity}\n" +
                $"Price: {myInvoice.PricePerItem:C}\n" +
                $"Amount: {myInvoice.GetInvoiceAmount():C}");