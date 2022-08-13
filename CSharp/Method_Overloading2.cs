using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_2
{

    class Book
    {
        int bookid;
        string title, author;
        int price;

        public void getdata()
        {
            bookid = 12;
            title = "Think like Monk";
            author = "Jay Shetty";
            price = 599;

        }
        //method overloaded
        public void getdata(int bookid)
        {
            this.bookid = bookid;

        }
        public void getdata(int bookid, string title)
        {
            this.bookid = bookid;
            this.title = title;

        }
        public void getdata(int bookid, string title, string author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;

        }
        public void getdata(string title, int bookid, string author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void getdata(int bookid, string title, string author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("book id : " + bookid);
            Console.WriteLine("book title : " + title);
            Console.WriteLine("book author : " + author);
            Console.WriteLine("price : " + price);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata();
            b.display();
            Console.WriteLine();

            Book b1 = new Book();
            b1.getdata(12, "Life Amazing Secrets");
            b1.display();
            Console.WriteLine();

            Book b2 = new Book();
            b2.getdata(111, "Think Like Monk", "Jay Shetty");
            b2.display();
            Console.WriteLine();

            Book b3 = new Book();
            Console.WriteLine("Enter Book Name : ");
            string bname=Console.ReadLine();
            Console.WriteLine("Enter Book ID : ");
            int bid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Author : ");
            string bauthor=Console.ReadLine();
            Console.WriteLine("Enter Book Price : ");
            int price = Convert.ToInt32(Console.ReadLine());


            b3.getdata(bname,bid,bauthor,price);
            Console.WriteLine();
            b3.display();


            Console.ReadLine();

        }
    }
}