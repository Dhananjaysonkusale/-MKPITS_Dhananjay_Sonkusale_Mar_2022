using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Class_Employee
{
    class Employee
    {
        string empname;
        int empid;
        string empdesignation;
        int salary;

        public Employee() //Constructor Employee
        {
            Console.WriteLine("Enter Employee Name : ");
            empname = Console.ReadLine();
            Console.WriteLine("Enter Employee ID : ");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Designation : ");
            empdesignation = Console.ReadLine();
            Console.WriteLine("Enter Salary : ");
            salary = Convert.ToInt32(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine("Product Name : " + empname);
            Console.WriteLine("Product Id : " + empid);
            Console.WriteLine("Product Price : " + empdesignation);
            Console.WriteLine("Product Quantity : " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Employee(); //Object Of Constructor Employee
            p.display();
            Console.ReadLine();

        }
    }
}
