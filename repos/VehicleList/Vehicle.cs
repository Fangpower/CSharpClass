/** @author Mikey Dowsett */
internal class Vehicle {
    public string Make { get; set; }
    public string Model { get; set; }

    private decimal price;

    public decimal Price {
        get => price;
        set { 
            if (value >= 0)
                price = value; 
        } 
    }

    public Vehicle() {
        Make = "";
        Model = "";
        Price = 0;
    }

    public Vehicle(string newMake, string newModel, decimal newPrice) {
        Make = newMake;
        Model = newModel;
        Price = newPrice;
    }

    public override string ToString() {
        return $"{Make},{Model},{Price:F}";
    }
}
