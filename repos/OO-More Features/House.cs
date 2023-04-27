/** @author Mikey Dowsett */
class House : Building {
    private int numBedrooms;
    public int NumBedrooms {
        get { return numBedrooms; }
        set {
            if (value >= 0)
                numBedrooms = value;
        }
    }
    public House() : base() {
        NumBedrooms = 0;
    }
    public House(int squareFeet, int numBedrooms) :
    base(squareFeet) {
        this.NumBedrooms = numBedrooms;
    }
    public override string ToString() {
        return base.ToString() + $", {NumBedrooms:D} BR";
    }

    public static House operator +(House left, House right) {
        return new House(left.SquareFeet + right.SquareFeet,
            left.numBedrooms + right.numBedrooms);
    }

    public static bool operator <(House left, House right){
        return left.SquareFeet < right.SquareFeet;
    }

    public static bool operator >(House left, House right) {
        return left.SquareFeet > right.SquareFeet;
    }

    public House DoubleSize() {
        NumBedrooms *= 2;
        SquareFeet *= 2;
        return this;
    }
}