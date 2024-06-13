using System;
using System.Collections.Generic;

namespace projekt_programowanie_obiektowe_AT
{
    class Program
    {
        // Klasa Book
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }

            public Book(string title, string author, string isbn)
            {
                this.Title = title;
                this.Author = author;
                this.ISBN = isbn;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Tytuł: {Title}, Autor: {Author}, ISBN: {ISBN}");
            }
        }

        // Klasa Library
        public class Library
        {
            private List<Book> books = new List<Book>();

            public void AddBook(Book book)
            {
                books.Add(book);
                Console.WriteLine("Książka została dodana do biblioteki.");
            }

            public void DisplayAllBooks()
            {
                Console.WriteLine("Książki w bibliotece:");
                foreach (Book book in books)
                {
                    book.DisplayInfo();
                }
            }
        }

        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("1. Dodaj książkę");
                Console.WriteLine("2. Wyświetl wszystkie książki");
                Console.WriteLine("3. Wyjście");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook(library);
                        break;
                    case "2":
                        library.DisplayAllBooks();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór.");
                        break;
                }
            }
        }

        private static void AddBook(Library library)
        {
            Console.WriteLine("Podaj tytuł:");
            string title = Console.ReadLine();

            Console.WriteLine("Podaj autora:");
            string author = Console.ReadLine();

            Console.WriteLine("Podaj ISBN:");
            string isbn = Console.ReadLine();

            Book book = new Book(title, author, isbn);
            library.AddBook(book);
        }
    }
}