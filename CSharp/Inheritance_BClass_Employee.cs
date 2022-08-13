using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BClass_Employee
{
    class Person
    {
        public string name;
        public string address;

    }
    class Employee : Person
    { 
        public int empno;
        public string designation;
        public int salary;


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.address = "Nagpur";
            emp.salary = 35000;
            emp.empno = 24;
            emp.name = "Kapil Sharma";
            emp.designation = "Manager";

            Console.WriteLine("Employee Name : "+emp.name);
            Console.WriteLine("Employee Address : "+emp.address);
            Console.WriteLine("Employee Designation : "+emp.designation);
            Console.WriteLine("Employee Salary : "+emp.salary);
            Console.WriteLine("Employee No : "+emp.empno);
        }
    }
}
