using System;

public class Title
{
    private string bookTitle;

    public Title(string title)
    {
        bookTitle = title;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Title: {bookTitle}");
        Console.ResetColor();
    }
}
