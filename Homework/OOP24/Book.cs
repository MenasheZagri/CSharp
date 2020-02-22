using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Book
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public Book(string title, string content, string author, string category)
        {
            Title = title;
            Content = content;
            Author = author;
            Category = category;
        }

        public int CompareTo(Book other)
        {
            return Author.CompareTo(other.Author);
        }
        public override string ToString()
        {
            return $"Title: {Title} Content: {Content} Author: {Author}  Category: {Category}";
        }
    }
}
