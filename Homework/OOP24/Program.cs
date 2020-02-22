using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary library = new MyLibrary();
            Book book1 = new Book("Catch22", "Yousarian!", "Joseph Heller", "WW2 Comedy");
            Book book2 = new Book("Catcher Rye", "Holden Claufield", "J.D. Salinger", "Realistic Fiction" );
            Book book3 = new Book("Clockwork Orange", "Alexander Delarge", "Anthony Burgess", "Dystopian Fiction" );

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(new Book("stage", "Something weird...", "Nani Namo", "Drama"));
            library.AddBook(new Book("The Hot Red-Head", "I have made it", "Anatomy1387", "Novel"));
            library.AddBook(new Book("There will be no armageddon", "It begins with a blip", "Union Jack", "Musical"));
            library.HaveThisBook("Catch22");
            library.HaveThisBook("what");
            library.RemoveBook("Catch22");
            library.HaveThisBook("Catch22");
            library.GetBookByAuthor("Nani Namo");




        }
    }
}
