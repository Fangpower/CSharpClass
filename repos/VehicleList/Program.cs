/**
* @author MikeyDowsett
* This program reads and displays vehicles from a file
*/

// Create a new empty list of vehicles
List<Vehicle> vehicles = new List<Vehicle>();

// Create a file stream to open vehicles.txt located in
// the VS source code folder. No error checking required.
StreamReader inFile = new StreamReader(new FileStream
    (@"..\..\..\Vehicles.txt", FileMode.Open));

// Read each line and add a new Vehicle object to the list
// based upon the values read.
string record;
while((record = inFile.ReadLine()) != null) {
    string[] data = record.Split(',');
    vehicles.Add(new Vehicle(data[0], data[1], decimal.Parse(data[2])));
}
inFile.Close();

// Loop through the list to display each vehicle
foreach (Vehicle vehicle in vehicles) {
    Console.WriteLine(vehicle);
}