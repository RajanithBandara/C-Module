using System;

public class Book
{
    string title;
    string auther;

    public Book(string Title, string Auther)
    {
        auther = Auther;
        title = Title;
    }

    public void Display()
    {
        Console.Write("Title: " + title);
        Console.WriteLine("Auther: " + auther);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book("C# programming", "Ali");
        Book b2 = new Book("Java programming", "Ahmed");

        b1.Display();
        b2.Display();
    }
}