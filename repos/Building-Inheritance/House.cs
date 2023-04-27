/**@author Mikey Dowsett*/
internal class House : Building {
    private int numBedrooms;
    public int NumBedrooms {
        get => numBedrooms;
        set {
            if(value >= 0)
                numBedrooms = value;
        }
    }

    public House() : base() {
        NumBedrooms = 0;
    }

    public House(int squareFeet, int numFloors, int numBedrooms) : 
        base(squareFeet, numFloors) 
    {
        NumBedrooms = numBedrooms;
    }

    public override string ToString() => base.ToString() +
        $"\nNumber of Bedrooms: {NumBedrooms}";
}
