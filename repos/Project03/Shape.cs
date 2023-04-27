/**@author Mikey Dowsett */
public abstract class Shape {
    string Color { get; set; }
    
    public Shape() {
        Color = "White";
    }

    public Shape(string color) {
        Color = color;
    }

    public override string ToString() => $"{base.GetType().Name},{Color}";

    public abstract double GetPerimeter();
    public abstract double GetArea();
}
