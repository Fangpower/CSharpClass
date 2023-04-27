/**
 * @author Mikey Dowsett
 */
internal class County {
    public string Name { get; set; }
    public string Seat { get; set; }
    private int population;

    public int Population {
        get => population;
        set {
            if(value >= 0)
                population = value;
        }
    }

    public County(string newName, string newSeat, int newPopulation) {
        Name = newName;
        Seat = newSeat;
        Population = newPopulation;
    }

    public override string ToString() {
        return $"County: {Name}\n  Seat: {Seat}\n  Population: {Population:N0}";
    }
}
