/**@author Mikey Dowsett */
class Program {
    static void Main(string[] args) {
        //Create an empty list named shapes that will hold Shape values.
        List<Shape> shapes = new List<Shape>();

        //GetShapes(shapes, "shapes.txt");
        GetShapes(shapes, "shapesWithBadData.txt");
        Console.WriteLine("Valid Shapes: ");
        ShowShapes(shapes);
    }

    static void GetShapes(List<Shape> shapes, string fileName) {
        StreamReader inFile = null;
        try {
            inFile = new StreamReader(
                new FileStream($"..//..//..//{fileName}", FileMode.Open));
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }

        string record = "";
        while((record = inFile.ReadLine()) != null) {
            try {
                string[] data = record.Split(',');
                if (String.Equals(data[0], "Rectangle", 
                    StringComparison.OrdinalIgnoreCase)) {
                    shapes.Add(new Rectangle(data[1], double.Parse(data[2]), 
                        double.Parse(data[3])));
                } else if(String.Equals(data[0], "Circle",
                    StringComparison.OrdinalIgnoreCase)) {
                    shapes.Add(new Circle(data[1], double.Parse(data[2])));
                }
            } catch (IllegalShapeException ex) {
                Console.WriteLine(ex.Message);
            }
        }
        inFile.Close();
    }

    static void ShowShapes(List<Shape> shapes) {
        foreach(Shape shape in shapes) {
            Console.WriteLine(shape.ToString());
            Console.WriteLine($"Perimeter {shape.GetPerimeter():N1} units");
            Console.WriteLine($"Area: {shape.GetArea():N1} sq. units");
            Console.WriteLine();
        }
    }
}