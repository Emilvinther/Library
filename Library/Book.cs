using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string title;
        private string author;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }


        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"Title = {Title}" +
                $"\nAuthor = {Author}";
        }
    }
}
