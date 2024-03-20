
using System;

class Title
{
    private string titleName;

    public Title(string titleName)
    {
        this.titleName = titleName;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Title: " + titleName);
        Console.ResetColor();
    }

    public string TitleName
    {
        get { return titleName; }
    }
}
