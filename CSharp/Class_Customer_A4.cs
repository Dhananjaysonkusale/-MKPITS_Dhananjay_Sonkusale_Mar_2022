using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Customer_A4
{
    class Customer
    {
        public string custname;
        public int custno;
        public string custadd;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer cust = new Customer();
            Console.WriteLine("Enter Your Name : ");
            cust.custname = Console.ReadLine();
            Console.WriteLine("Enter Your Address : ");
            cust.custadd = Console.ReadLine();
            Console.WriteLine("Enter Your Number : ");
            cust.custno=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Customer Name : "+cust.custname);
            Console.WriteLine("Customer Address : "+cust.custadd);
            Console.WriteLine("Customer Number : "+cust.custno);

        }
    }
}
