/**@author Mikey Dowsett */
public class TicketWindows {
    public void WindowOne(Object line) {
        Queue<Person> people = (Queue<Person>)line;
        Console.WriteLine("Window One Open.\n");

        while(people.Count > 0) {
            //Serve the next person in line.
            Person person = people.Dequeue();
            int tickets = person.TicketsNeeded;
            Console.WriteLine($"Window One: {person.FirstName} {person.LastName}" +
                $" est. service time: {tickets} seconds.\n");
            Thread.Sleep(1000 * (tickets + 1));

            //Tickets purchased
            person.TicketsNeeded = 0;
            Console.WriteLine($"Window One: {person.FirstName} {person.LastName}" +
                $" pruchased {tickets} tickets.\n");
        }
        Console.WriteLine("Window One Closed.");
    }

    public void WindowTwo(Object line) {
        Queue<Person> people = (Queue<Person>)line;
        Console.WriteLine("Window Two Open.\n");

        while (people.Count > 0) {
            //Serve the next person in line.
            Person person = people.Dequeue();
            int tickets = person.TicketsNeeded;
            Console.WriteLine($"Window Two: {person.FirstName} {person.LastName}" +
                $" est. service time: {tickets} seconds.\n");
            Thread.Sleep(1000 * (tickets + 1));

            //Tickets purchased
            person.TicketsNeeded = 0;
            Console.WriteLine($"Window Two: {person.FirstName} {person.LastName}" +
                $" pruchased {tickets} tickets.\n");
        }
        Console.WriteLine("Window Two Closed.");
    }

    public void WindowThree(Object line) {
        Queue<Person> people = (Queue<Person>)line;
        Console.WriteLine("Window Three Open.\n");

        while (people.Count > 0) {
            //Serve the next person in line.
            Person person = people.Dequeue();
            int tickets = person.TicketsNeeded;
            Console.WriteLine($"Window Three: {person.FirstName} {person.LastName}" +
                $" est. service time: {tickets} seconds.\n");
            Thread.Sleep(1000 * (tickets + 1));

            //Tickets purchased
            person.TicketsNeeded = 0;
            Console.WriteLine($"Window Three: {person.FirstName} {person.LastName}" +
                $" pruchased {tickets} tickets.\n");
        }
        Console.WriteLine("Window Three Closed.");
    }
}