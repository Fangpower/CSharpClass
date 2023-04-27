/**@author Mikey Dowsett*/
internal class Building {
    private int squareFeet;
    public int SquareFeet {
        get => squareFeet;
        set {
            if (value >= 0)
                squareFeet = value;
        }
    }

    private int numFloors;
    public int NumFloors {
        get => numFloors;
        set {
            if (value >= 0)
                numFloors = value;
        }
    }

    public Building() {
        SquareFeet = 0;
        NumFloors = 0;
    }

    public Building(int squareFeet, int numFloors) {
        SquareFeet = squareFeet;
        NumFloors = numFloors;
    }

    public override string ToString() => $"Square Feet: {SquareFeet}\n" +
        $"Number of Floors: {NumFloors}";
}
