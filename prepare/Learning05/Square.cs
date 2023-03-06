using System;

public class Square: Shape
{
    public Square(string color, float side) : base(color)
    {
        _side = side;
    }

    private float _side;

    public override float GetArea()
    {
        return _side * _side;
    }

}