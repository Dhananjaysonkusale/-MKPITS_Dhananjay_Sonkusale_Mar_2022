using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_2
{
    class Employeee
    {
        //Class having field empid,empname,empsal
        public int empid;
        public string empname;
        public int empsal;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an object(instance) of employee class
            //syntax classname objectname =new classname();
            // Declaration of variable objectname = value;
            Employeee emp = new Employeee();
            Console.WriteLine("Enter Employee ID : ");
            emp.empid= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name : ");
            emp.empname= Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Employee Sallary : ");
            emp.empsal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Employee ID : " + emp.empid);
            Console.WriteLine("Employee Name : " + emp.empname);
            Console.WriteLine("Employee Sallary : " + emp.empsal);
            Console.ReadLine();

        }
    }
}