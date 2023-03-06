using System;

public class Shape
{
    string _color = "";

    public Shape(string color) //Constructor
    {
     _color = color;
    }

    public string GetColor() //Getter
    {
    return _color;
    }

    public void SetColor(string color) //Setter
    {
    _color = color;
    }

    public virtual float GetArea() 
    {
        return 0.0f;
    }
}
