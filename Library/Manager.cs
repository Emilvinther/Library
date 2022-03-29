using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Manager
    {
        public List<Book> books = new List<Book>();

        public Manager()
        {
            Book book1 = new Book("Harry Potter", "J.K Rowling");
            Book book2 = new Book("Lord of the Rings", "Tolkien");
            Book book3 = new Book("Bible", "Moses m.fl");

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

        }
    }
}
