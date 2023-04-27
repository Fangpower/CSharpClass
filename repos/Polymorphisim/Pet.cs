/**@author Mikey Dowsett*/
public abstract class Pet {
    public string Name { get; set; }
    private double weight;
    public double Weight {
        get => weight;
        set {
            if (value >= 0)
                weight = value;
        }
    } // end property Weight

    public abstract void Speak(int numTimes);
} // end class