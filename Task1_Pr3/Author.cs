using System;

class Author
{
    private string authorName;

    public Author(string authorName)
    {
        this.authorName = authorName;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Author: " + authorName);
        Console.ResetColor();
    }

    public string AuthorName
    {
        get { return authorName; }
        set { authorName = value; }
    }
}
