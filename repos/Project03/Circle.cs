/**@author Mikey Dowsett */
public class Circle : Shape {
    private double radius;
    public double Radius {
        get => radius;
        set {
            if (value <= 0)
                throw new IllegalShapeException($"Circle radius of {value:N1}");
            else
                radius = value;
        }
    }

    public Circle() : base() {
        radius = 1;
    }

    public Circle(string color, double radius) : base(color) {
        Radius = radius;
    }

    public override string ToString() => $"{base.ToString()},{Radius:N1}";

    public override double GetPerimeter() => 2 * Math.PI * Radius;

    public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
}