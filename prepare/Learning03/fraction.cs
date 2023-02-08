using System;

class Fraction
{

    private int topNum;
    private int botNum;

   public Fraction()
   {
        topNum = 1;
        botNum = 1;
   }

    public Fraction(int num)
    {
        topNum = num;
        botNum = 1;
    }

    public Fraction(int num1, int num2)
    {
        topNum = num1;
        botNum = num2;
    }

     public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{topNum}/{botNum}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)topNum / (double)botNum;
    }

}