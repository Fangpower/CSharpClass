/**@author Mikey Dowsett */
public class Person {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int TicketsNeeded { get; set; }

    public Person(string fName, string lName, int tickets) { 
        FirstName = fName;
        LastName = lName;
        TicketsNeeded = tickets;
    }
}