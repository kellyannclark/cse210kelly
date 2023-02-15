using System;
using System.Collections.Generic;
using System.IO;

public class Scripture
{
    public string Reference { get; set; }
    public string FirstVerse { get; set; }
    public string SecondVerse { get; set; }

    public Scripture(string reference, string firstVerse, string secondVerse)
    {
        // Constructor for the Scripture class
        // Sets the reference and text properties
        Reference = reference;
        FirstVerse = firstVerse;
        SecondVerse = secondVerse;
    }

    public string Text
    {
        // Implement the Text property to generate the full text of the scripture
        get { return FirstVerse + " " + SecondVerse; }
    }
}