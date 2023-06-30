using System;
using System.Collections.Generic;

public class Book
{
    private string title;
    private string author;
    private int year;

    public Book(string t, string a, int y)
    {
        title = t;
        author = a;
        year = y;
    }

    public string Title
    {
        get { return title; }
    }

    public string Author
    {
        get { return author; }
    }

    public int Year
    {
        get { return year; }
    }
}

public class Reader
{
    private string name;
    private int age;
    private List<Book> borrowedBooks;

    public Reader(string n, int a)
    {
        name = n;
        age = a;
        borrowedBooks = new List<Book>();
    }

    public string Name
    {
        get { return name; }
    }

    public int Age
    {
        get { return age; }
    }

    public void BorrowBook(Book book)
    {
        borrowedBooks.Add(book);
    }

    public void ReturnBook(Book book)
    {
        borrowedBooks.Remove(book);
    }

    public void DisplayBorrowedBooks()
    {
        Console.WriteLine("Borrowed books:");
        foreach (var book in borrowedBooks)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
        }
    }
}

public class Library
{
    private List<Book> books;
    private List<Reader> readers;

    public Library()
    {
        books = new List<Book>();
        readers = new List<Reader>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public void AddReader(Reader reader)
    {
        readers.Add(reader);
    }

    public void RemoveReader(Reader reader)
    {
        readers.Remove(reader);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Library books:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
        }
    }

    public void DisplayReaders()
    {
        Console.WriteLine("Library readers:");
        foreach (var reader in readers)
        {
            Console.WriteLine($"Name: {reader.Name}, Age: {reader.Age}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book("Title 1", "Author 1", 2021);
        Book book2 = new Book("Title 2", "Author 2", 2022);

        library.AddBook(book1);
        library.AddBook(book2);

        Reader reader1 = new Reader("John", 25);
        Reader reader2 = new Reader("Emily", 30);

        library.AddReader(reader1);
        library.AddReader(reader2);

        reader1.BorrowBook(book1);
        reader2.BorrowBook(book2);

        library.DisplayBooks();
        library.DisplayReaders();

        reader1.DisplayBorrowedBooks();
    }
}