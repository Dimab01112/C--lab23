using System;

public class Book
{
    private readonly Title title;
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

    public void SetAuthorName(string authorName)
    {
        author.AuthorName = authorName;
    }

    public void SetBookContent(string bookContent)
    {
        content.BookContent = bookContent;
    }
}
