/**
 * @author Mikey Dowsett
 * Program simulates a simple user authentication system.
 */
const string USERNAME = "jccc";
const string PASSWORD = "cavs";
const int MAX_LOGIN_ATTEMPTS = 3;

//Get the authentication information
Console.Write("Username: ");
string username = Console.ReadLine();
Console.Write("Password: ");
string password = Console.ReadLine();
int numLoginAttempts = 1;

//If invalid information, re-authenticate up to MAX_LOGIN_ATTEMPTS
//additional times
while((username.ToLower() != USERNAME || password != PASSWORD) &&
    numLoginAttempts < MAX_LOGIN_ATTEMPTS) {
    Console.WriteLine("Login incorrect. Please re-enter your " +
        "username and password.");
    Console.Write("Username: ");
    username = Console.ReadLine();
    Console.Write("Password: ");
    password = Console.ReadLine();
    numLoginAttempts++;
}

//Display appropriate login message
if(username.ToLower() == USERNAME && password == PASSWORD) {
    Console.WriteLine("Logging in...");
} else {
    Console.WriteLine("Login disabled. Please contact your administrator.");
}