using System;

class Program
{
    static void Main()
    {
        Book myBook = new Book();


        myBook.AddTitle("Name");
        myBook.AddAuthor("Author");
        myBook.AddContent("Content");


        myBook.Show();
    }
}

class Book
{
    private Title title;
    private Author author;
    private Content content;

    public Book()
    {
        title = new Title();
        author = new Author();
        content = new Content();
    }

    public void AddTitle(string bookTitle)
    {
        title.SetTitle(bookTitle);
    }

    public void AddAuthor(string authorName)
    {
        author.SetAuthor(authorName);
    }

    public void AddContent(string bookContent)
    {
        content.SetContent(bookContent);
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        title.Show();

        Console.ForegroundColor = ConsoleColor.Green;
        author.Show();

        Console.ForegroundColor = ConsoleColor.Red;
        content.Show();

        Console.ResetColor();
    }
}

class Title
{
    private string title;

    public void SetTitle(string bookTitle)
    {
        title = bookTitle;
    }

    public void Show()
    {
        Console.WriteLine($"Book name: {title}");
    }
}

class Author
{
    private string author;

    public void SetAuthor(string authorName)
    {
        author = authorName;
    }

    public void Show()
    {
        Console.WriteLine($"Author: {author}");
    }
}

class Content
{
    private string content;

    public void SetContent(string bookContent)
    {
        content = bookContent;
    }

    public void Show()
    {
        Console.WriteLine($"Book content: {content}");
    }
}
