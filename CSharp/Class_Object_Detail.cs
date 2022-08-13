using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_Detail
{
   /*  Declaration Of Class
     class Class_Name
    {
        //class member;
        1)class variable
        2)Class method
    }*/
    class Employee
    {
        public int id; //field of a class
        public string name;
        public int age;
        public int salary;

        public void Getdata(int id,string name,int age,int salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
        public void showdata()
        {
            Console.WriteLine("Employee ID : "+id);
            Console.WriteLine("Employee Name : "+name);
            Console.WriteLine("Employee Age : "+age);
            Console.WriteLine("Employee Salary : "+salary);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(); // Object Of Class Employee
            
            Console.WriteLine("Enter Employee Id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary : ");
            int salary = Convert.ToInt32(Console.ReadLine());

            emp.Getdata(id, name, age, salary);
         //   emp.Getdata(24,"Dhananjay",22,45000);
            emp.showdata();
            
        }
    }
}
