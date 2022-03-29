using System;
using System.Collections.Generic;
using System.Linq;

namespace Library

    
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Book> booksinstack = new Stack<Book>();

            string pushbook = "";

            Manager manager = new Manager();

            Console.WriteLine("Available books\n");
            foreach (Book i in manager.books)
            {
                Console.WriteLine(i.Title);
            }


            Console.WriteLine("\nWhat book would you like you check out?");
            pushbook = Console.ReadLine();

            Book x = manager.books.Find(x => x.Title == pushbook);

            booksinstack.Push(x);
            manager.books.Remove(x);

            foreach (Book i in booksinstack)
            {
                Console.WriteLine(i.Title);
            }

            try
            {
                while (booksinstack.Count() > 0)
                {
                    Console.WriteLine(booksinstack.Pop());
                }
            }
            catch (Exception)
            {

                throw;
            }

            

          



            Console.ReadKey();


       
          
        }
    }
}
