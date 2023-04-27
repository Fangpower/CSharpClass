/**
* @author MikeyDowsett
* Class Program gives values to array bag before
* dispaying the value of each item.
*/
internal class Program {
    static void Main(string[] args) {
        const int MAX_ITEMS = 3;
        List<Candy> bag = new List<Candy>(MAX_ITEMS);

        FillBag(bag);
        ShowBagContents(bag);
    }

    static void FillBag(List<Candy> bag) {
        bag.Add(new Candy("Snickers", 1));
        bag.Add(new Candy("Reeces", 1.25m));
        bag.Add(new Candy("Rollos", 0.75m));
    }

    static void ShowBagContents(List<Candy> bag) {
        foreach (Candy candy in bag) {
            Console.WriteLine(candy.ToString());
        }
    }
}