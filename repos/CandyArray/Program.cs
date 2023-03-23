/**
* @author MikeyDowsett
* Class Program gives values to array bag before
* dispaying the value of each item.
*/
internal class Program {
    const int MAX_ITEMS = 3;

    static void Main(string[] args) {
        Candy[] bag = new Candy[MAX_ITEMS];
        FillBag(bag);
        ShowBagContents(bag);
    }

    static void FillBag(Candy[] bag) {
        bag[0] = new Candy("KitKat", 1.0m);
        bag[1] = new Candy("Milky Way", 0.9m);
        bag[2] = new Candy("Jolly Rancher", 1.25m);
    }

    static void ShowBagContents(Candy[] bag) {
        foreach (Candy candy in bag) {
            Console.WriteLine(candy.ToString());
        }
    }
}