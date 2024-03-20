using System;

class Content
{
    private string bookContent;

    public Content(string bookContent)
    {
        this.bookContent = bookContent;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Content: " + bookContent);
        Console.ResetColor();
    }

    public string BookContent
    {
        get { return bookContent; }
        set { bookContent = value; }
    }
}
