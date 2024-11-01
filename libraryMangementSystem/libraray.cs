using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryMangementSystem
{
    internal class libraray
    {

        private List<Book> books = new List<Book>();
        
        private List<Book> BorrowBooks = new List<Book>();


        public void Add (Book book)
        {
            books.Add(book);
            
            Console.WriteLine("Added book sucssefully ");
        }
        public void Remove (Book book)
        {
           bool c = books.Contains(book);
            if (c == true)
            {
                books.Remove(book);
                Console.WriteLine("removed was done");
            }
            else
                Console.WriteLine("not found ");
        }
        public void Display()
        {
            foreach (var item in books)
            {
                Console.WriteLine($"{item.Title}     {item.Author}      {item.year}");
            }
        }
        public void Borrow(Book book)
        {
           
                books.Remove(book);
                Console.WriteLine("borrowed book was done..! ");

        }
    }
}
