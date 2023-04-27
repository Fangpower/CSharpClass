/**@author Mikey Dowsett */
public class IllegalShapeException : Exception { 
    public IllegalShapeException(string message)
        : base("Illegal Shape: " + message) {}
}