using System;

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
