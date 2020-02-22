using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class MyLibrary
    {
        Dictionary<string, Book> books;

        public MyLibrary()
        {
            books = new Dictionary<string, Book>();
        }

        public bool AddBook(Book book)
        {
            if (books.ContainsKey(book.Title))
            {
                Console.WriteLine("Title exists in dictionary!");
                return false;
            }
            else
            {
                Console.WriteLine($"Adding '{book.Title}' to the books list");
                books.Add(book.Title, book);
                return true;
            }

        }

        public bool RemoveBook(string title)
        {
            if (books.ContainsKey(title))
            {
                Console.WriteLine($"Removing '{title}' from the books list");
                books.Remove(title);
                return true;
            }
            else
            {
                Console.WriteLine($"'{title}' not found, was not removed.");
            }
            return true;
        }

        public bool HaveThisBook(string title)
        {
            if (books.ContainsKey(title))
            {
                Console.WriteLine($"Checking if I have this book:... '{title}' exists");
                return true;
            }
            else
            {
                Console.WriteLine($"Checking if I have this book:... '{title}' not found");
                return false;
            }
        }
        

        public Book GetBook(string title)
        {
            if (!books.ContainsKey(title))
            {
                return null;
            }
            return books[title];
        }

        //Retrieve value from object/ list/ dictionary
        public Book GetBookByAuthor(string authorName)
        {
            foreach (Book book in books.Values)
            {
                
                if (book.Author == authorName)
                    Console.WriteLine($"{authorName} exists in the library");
                    return book;
            }
            return null;
        }

        public void Clear()
        {
            Console.WriteLine($"Clearing {books} dictionary");
            books.Clear();
        }

        /*
        public List<string> GetAuthors()
        {
            string result = String.Empty;
            foreach (var VARIABLE in books.Values)
            {
                
            }
        }
        */

        public List<Book> GetBooksSortedByAuthorName()
        {
            List<Book> sortedByAuthors = new List<Book>();
            foreach (Book book in books.Values)
            {
                sortedByAuthors.Add(book);
            }
            sortedByAuthors.Sort();
            return sortedByAuthors;

        }

        public List<string> GetBooksSortedByTitle()
        {
            List<String> sortedByTitle = new List<String>();

            foreach (Book book in books.Values)
            {
                sortedByTitle.Add(book.Title);
            }
            sortedByTitle.Sort();
            return sortedByTitle;
        }

        public int Count()
        {
            return books.Count;
        }
        
        public override string ToString()
        {
            foreach (var VARIABLE in books)
            {
                Console.WriteLine(VARIABLE);
            }
            return "";
        }
    }   
    
}
