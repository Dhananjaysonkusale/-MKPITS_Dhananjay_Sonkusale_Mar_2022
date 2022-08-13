using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_With_Parameter_Or_Without_Parameter
{
    class Book
    {
        string bookname,author;
        int bookid,price;

        public Book()
        {
            Console.WriteLine("Constructor Without Parameter Called");
            Console.WriteLine("Enter Book Name : ");
            bookname=Console.ReadLine();
            Console.WriteLine("Enter Book Author : ");
            author=Console.ReadLine();
            Console.WriteLine("Enter Book Id : ");
            bookid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Price : ");
            price=Convert.ToInt32(Console.ReadLine());
        }
        public Book(string bookname, string author, int bookid, int price)
        {
            Console.WriteLine("Constructor With Parameter Called");
            this.bookname = bookname;
            this.author = author;
            this.bookid = bookid;
            this.price = price;
        }
        public void display()
        {
            
            Console.WriteLine("Book Name : " + bookname);
            Console.WriteLine("Book Author : " + author);
            Console.WriteLine("Book ID : " + bookid);
            Console.WriteLine("Book Price : " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();

            Book b1 = new Book("Life Amazing Secrets", "Gaur Gopal Das", 23, 499);
            b1.display();
            Console.ReadLine();
        }
    }
}
