/**
 * @author Mikey Dowsett
 * Class Candy stores information about a candy piece.
 */
internal class Candy {
    public string Name { get; set; }

    private decimal price;
    public decimal Price {
        get => price;
        set {
            if (value >= 0) {
                price = value;
            }
        } 
    }

    public Candy() {
        Name = "";
        Price = 0;
    }

    public Candy(string newName, decimal newPrice) {
        Name = newName;
        Price = newPrice;
    }

    public override string ToString() {
        return $"{Name}, {Price:C}";
    }
}
