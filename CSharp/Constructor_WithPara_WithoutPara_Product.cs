using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_WithPara_Without_ParaProduct
{
    class Product
    {
        string pname;
        int price,quant, id;

        public Product()
        {

            Console.WriteLine("Enter Product Name : ");
            pname = Console.ReadLine();
            Console.WriteLine("Enter Product Price : ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity : ");
            quant = Convert.ToInt32(Console.ReadLine());
        }
        public Product(string pname, int price, int id, int quant)
        {

            this.pname = pname;
            this.id = id;
            this.price = price;
            this.quant = quant;
        }
        public void display()
        {

            Console.WriteLine("Book Name : " + pname);
            Console.WriteLine("Book Author : " + id);
            Console.WriteLine("Book ID : " + price);
            Console.WriteLine("Book Price : " + quant);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.display();

            Product p1 = new Product("Parle",58 , 5, 30);
            p1.display();
            Console.ReadLine();
        }
    }
}
