using System;

public class Shape
{
    string _shape = "";

    public Shape(string shape) //Constructor
    {
     _shape = shape;
    }

    public string GetShape() //Getter
    {
    return _shape
    }

    public void SetShape(string shape) //Setter
    {
    _shape = shape;
    }

    public virtual float GetArea() 
    {
        return 0.0;
    }
}
