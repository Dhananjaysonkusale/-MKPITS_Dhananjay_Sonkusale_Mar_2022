using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Customer_Using_Method_A5
{
    class Customer
    {
        public string custname;
        public int custno;
        public string custadd;

        public void getdata(string a,string b,int c)
        {
            custname = a;
            custadd = b;
            custno = c;
        }
        public void displaydata()
        {
            Console.WriteLine("Customer Name : " + custname);
            Console.WriteLine("Customer Address : " + custadd);
            Console.WriteLine("Customer Number : " + custno);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer cust = new Customer();
            Console.WriteLine("Enter Your Name : ");
            string custname = Console.ReadLine();
            Console.WriteLine("Enter Your Address : ");
            string custadd = Console.ReadLine();
            Console.WriteLine("Enter Your Number : ");
            int custno = Convert.ToInt32(Console.ReadLine());

            cust.getdata(custname, custadd, custno);
            cust.displaydata();

        }
    }

}
