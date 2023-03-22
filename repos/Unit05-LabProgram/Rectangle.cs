/**
* @author Mikey Dowsett
* Class Rectangle represents a rectangle with a length and width.
*/
internal class Rectangle {
    private int length, width;

    public int Length {
        get 
            { return length; }
        set {
            if(value > 0)
                length = value; 
        }
    }

    public int Width { 
        get 
            { return width; } 
        set { 
            if(value > 0)
                width = value;
        } 
    }

    public Rectangle(int _legnth, int _width) {
        Length = _legnth;
        Width = _width;
    }
} //End Main
