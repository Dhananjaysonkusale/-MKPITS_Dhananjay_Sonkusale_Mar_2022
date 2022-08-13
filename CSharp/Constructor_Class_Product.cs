using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Class_Product
{
    class Product
    {
        string productname;
        int productid;
        int productprice;
        int productquant;

        public Product()
        {
            Console.WriteLine("Enter Product Name : ");
            productname = Console.ReadLine();
            Console.WriteLine("Enter Product ID : ");
            productid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Price : ");
            productprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity : ");
            productquant = Convert.ToInt32(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine("Product Name : "+productname);
            Console.WriteLine("Product Id : "+productid);
            Console.WriteLine("Product Price : "+productprice);
            Console.WriteLine("Product Quantity : "+productquant);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(); //Object Of Constructor Product
            p.display();
            Console.ReadLine();

        }
    }
}
