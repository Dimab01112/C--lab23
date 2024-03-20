using System;

class Program
{
    static void Main()
    {
        Book myBook = new Book("Book", "Name", "Content");

        myBook.Show();

        myBook.SetAuthorName("Name2");
        myBook.SetBookContent("Content2");

        myBook.Show();
    }
}


