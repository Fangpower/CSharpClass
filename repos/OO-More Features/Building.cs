/** @author Mikey Dowsett */
class Building : IComparable<Building> {
    private int squareFeet;
    public int SquareFeet {
        get { return squareFeet; }
        set {
            if (value >= 0)
                squareFeet = value;
        }
    }
    public Building() {
        SquareFeet = 0;
    }
    public Building(int newSquareFeet) {
        SquareFeet = newSquareFeet;
    }
    public override string ToString() {
        return $"{SquareFeet:D} sq ft";
    }

    public static Building operator ++(Building building) {
        building.SquareFeet++;
        return building;
    }

    public int CompareTo(Building building) {
        return SquareFeet - building.SquareFeet;
    }
}