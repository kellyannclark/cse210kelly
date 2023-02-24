using System;

public class Activity
{
    private string _title = "";
    private string _description = "";
    private int _duration = 0;

    public Activity(string title, string description, int duration) //Object Constructor #1
    {
        _title = title;
        _description = description;
        _duration = duration;
    }

    public string GetTitle() //Getter
    {
        return _title;
    }

    public void SetTitle(string title) //Setter
    {
        _title = title;
    }

    public string GetDescription()//Getter
    {
        return _description;
    }

    public void SetDescription(string description)//Setter
    {
        _description = description;
    }

    public int GetDuration() //Getter
{
    
        return _duration;
    
}

    public void SetDuration(int duration) //Setter
    {
        _duration = duration;
    }

}