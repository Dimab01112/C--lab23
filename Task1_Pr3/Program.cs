using System;

class Book
{
    private Title title;
    private Author author;
    private Content content;

    public Book(string bookTitle, string authorName, string bookContent)
    {
        title = new Title(bookTitle);
        author = new Author(authorName);
        content = new Content(bookContent);
    }

    public void Show()
    {
        title.Show();
        author.Show();
        content.Show();
    }


    public string BookTitle
    {
        get { return title.TitleName; }
    }

    public string AuthorName
    {
        get { return author.AuthorName; }
        set { author.AuthorName = value; }
    }

    public string BookContent
    {
        get { return content.BookContent; }
        set { content.BookContent = value; }
    }
}

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

class Program
{
    static void Main(string[] args)
    {
        Book myBook = new Book("The book", "Name of author", "Context");
        myBook.Show();

        Console.WriteLine("\nChanging author's name...");
        myBook.AuthorName = "someone2";
        myBook.Show();

        Console.WriteLine("\nChanging book content...");
        myBook.BookContent = "Context2.";
        myBook.Show();

        Console.WriteLine("\nChanging author's name...");
        myBook.AuthorName = "someone";
        myBook.Show();

    }
}

    }
}
