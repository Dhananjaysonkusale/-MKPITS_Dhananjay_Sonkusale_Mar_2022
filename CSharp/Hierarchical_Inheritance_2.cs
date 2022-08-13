using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heirarchical_Inheritance_2
{
    public class Store
    {
        string pname;
        int id;
        public void getPersonData(string pname, int id)
        {
            this.pname = pname;
            this.id = id;
        }
        public void displayPersonData()
        {
            Console.WriteLine("Product Name : " + pname);
            Console.WriteLine("Product ID : " + id);

        }
    }

    public class Product : Store
    {

        int price;
        int quant;
        public void getStudentData(int price, int quant)
        {

            this.price = price;
            this.quant = quant;
        }
        public void displayStudentData()
        {

            Console.WriteLine("Product Price : " + price);

            Console.WriteLine("Product Quantity : " + quant);
            Console.WriteLine("--------------------------");
        }
    }
    public class Customer : Store
    {
        string cname;
        string address;
        public void getEmployeeData(string cname, string address)
        {
            this.cname = cname;
            this.address = address;
        }
        public void displayEmployeeData()
        {
            Console.WriteLine("Customer Name : " + cname);
            Console.WriteLine("Customer Address : " + address);
            Console.WriteLine("--------------------------");
        }
    }

    class TestInheritance
    {
        public static void Main(string[] args)
        {

            Product p1 = new Product();
            p1.getPersonData("TV", 25);
            p1.getStudentData(20000, 2);
            p1.displayPersonData();
            p1.displayStudentData();


            Customer e1 = new Customer();
            e1.getPersonData("Laptop", 24);

            e1.getEmployeeData("Mr.Shukla", "Nagpur");
            e1.displayPersonData();
            e1.displayEmployeeData();

        }
    }
}

