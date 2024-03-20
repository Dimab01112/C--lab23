
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
