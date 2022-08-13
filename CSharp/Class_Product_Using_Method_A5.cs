using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Product_Using_Method_A5
{
    class Product
    {
        public string proname;
        public int proid;
        public int proquant;
        public int prorate;
        

        public void getdata(string a, int b, int c,int d)
        {
            proname = a;
            proid = b;
            proquant = c;
            prorate = d;

        }
        public void displayorder()
        {
            int total = proquant * prorate;
            Console.WriteLine("Customer Name : " + proname);
            Console.WriteLine("Customer Address : " + proid);
            Console.WriteLine("Customer Number : " + proquant);
            Console.WriteLine("Customer Number : " + prorate);
            Console.WriteLine("Customer Number : " + total);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Product pro = new Product();
            Console.WriteLine("Enter Product Name : ");
            string proname = Console.ReadLine();
            Console.WriteLine("Enter Product ID : ");
            int proid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity : ");
            int proquant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity : ");
            int prorate = Convert.ToInt32(Console.ReadLine());


            pro.getdata(proname, proid, prorate,proquant);
            pro.displayorder();

        }
    }
}
