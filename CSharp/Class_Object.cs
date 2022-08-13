using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Object_1
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
            emp.empid = 123;
            emp.empname = "Dhananjay";
            emp.empsal = 30000;

            Console.WriteLine("Employee ID : "+ emp.empid);
            Console.WriteLine("Employee Name : "+ emp.empname);
            Console.WriteLine("Employee Sallary : "+ emp.empsal);
            Console.ReadLine();

        }
    }
}
