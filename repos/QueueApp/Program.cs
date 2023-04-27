/**@author Mikey Dowsett */
class Program { 
    static void Main(String[] args) {
        const int NUM_TICKET_LINES = 3;

        Queue<Person>[] lines = new Queue<Person>[NUM_TICKET_LINES];
        for(int i = 0; i < NUM_TICKET_LINES; i++) {
            lines[i] = new Queue<Person>();
        }
        ReadFile("TicketCustomers.csv", lines);

        //Create Ticket Windows
        TicketWindows ticketWindows = new TicketWindows();
    }

    public static void ReadFile(string filename, Queue<Person>[] lines) {
        StreamReader inFile = null;
        try {
            inFile = new StreamReader(
                new FileStream($"..\\..\\..\\{filename}", FileMode.Open));
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }

        string record = inFile.ReadLine();
        int qNumber = 0;
        while ((record = inFile.ReadLine()) != null) {
            string[] data = record.Split(',');
            lines[qNumber].Enqueue(new Person(data[0], data[1], int.Parse(data[2])));
            qNumber = (qNumber + 1) % lines.Length;
        }
        inFile.Close();
    }
}