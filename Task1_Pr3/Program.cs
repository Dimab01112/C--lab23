using System;

class Program
{
    static void Main()
    {
        Book myBook = new Book("Sample Book", "John Doe", "This is the content of the book.");

        myBook.Show();

       
        myBook.AuthorName = "Jane Smith";
        myBook.BookContent = "Updated content of the book.";

        myBook.Show();
    }
}

