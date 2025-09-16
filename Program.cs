// See https://aka.ms/new-console-template for more information
using System;

namespace Lab2Library
{
    class Program
    {
        static void Main()
        {
            Library library = new Library();

            // Додаємо книги
            library.AddBook(new Book("Harry Potter", "J.K. Rowling"));
            library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien"));

            // Виводимо всі книги
            Console.WriteLine("All books in the library:");
            library.PrintAllBooks();

            // Шукаємо книгу
            var book = library.GetBookByTitle("Harry Potter");
            Console.WriteLine();
            if (book != null)
            {
                Console.WriteLine($"Found: {book}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}
