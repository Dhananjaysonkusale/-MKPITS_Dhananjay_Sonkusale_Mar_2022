using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_getdata_Showdata
{
    class Employee
    {
        public int empid;
        public string empname;
        public int empsal;

        public void getdata()
        {
            Console.WriteLine("Enter Employee ID : ");
            empid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            empname=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Sallary : ");
            empsal=Convert.ToInt32(Console.ReadLine());

        }
        public void showdata()
        {
            Console.WriteLine("Employee ID : "+empid);
            Console.WriteLine("Employee ID : "+empname);
            Console.WriteLine("Employee ID : "+empsal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an object(instance) of employee class
            //syntax classname objectname =new classname();
            Employee emp = new Employee();
            emp.getdata();
            emp.showdata();
            Console.ReadLine();
        }
    }
}
