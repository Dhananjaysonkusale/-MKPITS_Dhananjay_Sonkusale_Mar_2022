using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_WithPara_WithoutPara_Employee
{
    class Employee
    {
        string empname, designation;
        int salary, id;

        public Employee()
        {
            
            Console.WriteLine("Enter Employee Name : ");
            empname = Console.ReadLine();
            Console.WriteLine("Enter Designation : ");
            designation = Console.ReadLine();
            Console.WriteLine("Enter Employee Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public Employee (string empname, string designation, int id, int salary)
        {
            
            this.empname = empname;
            this.id = id;
            this.designation = designation;
            this.salary = salary;
        }
        public void display()
        {

            Console.WriteLine("Book Name : " + empname);
            Console.WriteLine("Book Author : " + id);
            Console.WriteLine("Book ID : " + designation);
            Console.WriteLine("Book Price : " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.display();

            Employee e1 = new Employee("Suraj Kumar","Manager",45,350000);
            e1.display();
            Console.ReadLine();
        }
    }
}
