using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Employee
{
    class Employee
    {
        public int empid;
        public string empname;
        public string designation;
        public float bsalary;
        public float hra;
        public float da;
        public float ta;
        public float total;
        

        public void getdata()
        {

            Console.Write("Enter Your Employee ID : ");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Name : ");
            empname = Console.ReadLine();
            Console.Write("Enter Your Designation : ");
            designation = Console.ReadLine();
            Console.Write("Enter Your Basic Salary: ");
            bsalary = Convert.ToInt32(Console.ReadLine());

        }
        public void showdata()
        {
            hra = (bsalary * 0.32f);
            Console.WriteLine("HRA = "+hra);
            da = (bsalary * 0.43f);
            Console.WriteLine("DA = " + da);
            ta = (bsalary * 0.45f);
            Console.WriteLine("TA = " + ta);

            total = hra + da + ta + bsalary;
            Console.WriteLine("Total Salary = "+total);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getdata();
            emp.showdata();

            Console.ReadLine();
        }
    }
}
