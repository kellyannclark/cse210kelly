using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("John Smith", "History");
        Console.WriteLine(assignment1.GetSummary());
        
         MathAssignment mathAssignment = new MathAssignment("John Smith", "Math", "Eight", "10-25");
        Console.WriteLine(mathAssignment.GetHomework());
        Console.WriteLine(mathAssignment.GetSummary());
    
    }
}