using System;

class Program
{
    static void Main()
    {
        Book myBook = new Book();

        myBook.Title = "The Witcher";
        myBook.Author = "Andrzej Sapkowski";
        myBook.Content = "Good book";

        myBook.Show();
    }
}

class Book
{
    private string title;
    private string author;
    private string content;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string Content
    {
        get { return content; }
        set { content = value; }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Book name: {Title}");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Author: {Author}");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Book content: {Content}");

        Console.ResetColor();
    }
}
