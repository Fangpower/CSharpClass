/**@author Mikey Dowsett */
public class Rectangle : Shape {
    private double length;
    public double Length {
        get => length;
        set {
            if (value <= 0)
                throw new IllegalShapeException($"Rectangle length of {value:N1}");
            else
                length = value;
        }
    }

    private double width;
    public double Width {
        get => width;
        set {
            if (value <= 0)
                throw new IllegalShapeException($"Rectangle width of {value:N1}");
            else
                width = value;
        }
    }

    public Rectangle() : base() {
        length = 1;
        width = 1;
    }

    public Rectangle(string color, double length, double width) : base(color) {
        Length = length;
        Width = width;
    }

    public override string ToString() => 
        $"{base.ToString()},{Length:N1},{Width:N1}";

    public override double GetPerimeter() => 
        Length*2 + Width*2;

    public override double GetArea() => Length * Width;

}