using System;

public class Content
{
    private string bookContent;

    public string BookContent
    {
        get { return bookContent; }
        set { bookContent = value; }
    }

    public Content(string content)
    {
        bookContent = content;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Content: {bookContent}");
        Console.ResetColor();
    }
}

