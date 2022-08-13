using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    
    class Book 
    {
        int bookid;
        string title,author;
        int price;

        //creating constructor with no parameter 
        public Book()  // This is Constructor 
        {
            bookid = 23;
            title = "Think Like a Monk";
            author = "Jay Shetty";
            price = 499;
        }
        public void display()
        {
            Console.WriteLine("Book Id : "+bookid);
            Console.WriteLine("Book Title : "+title);
            Console.WriteLine("Book Author : "+author);
            Console.WriteLine("Book Price : "+price);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();// Object of a Constructor 
            // this will call Constructor Automatically
            b1.display();
            Console.ReadLine();

        }
    }
}
