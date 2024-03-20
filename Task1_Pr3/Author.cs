using System;

public class Author
{
    private string authorName;

    public string AuthorName
    {
        get { return authorName; }
        set { authorName = value; }
    }

    public Author(string name)
    {
        authorName = name;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Author: {authorName}");
        Console.ResetColor();
    }
}
