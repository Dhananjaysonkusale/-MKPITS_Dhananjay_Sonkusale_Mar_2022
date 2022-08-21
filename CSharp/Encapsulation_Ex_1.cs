using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Ex_1
{
    internal class Program
    {
        class employee
        {
            // string empname;
            public string empname { get; set; }
        }
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.empname = " Dhananjay "; //this will call setter
            Console.WriteLine("Employee Name : " + emp.empname);
        }
    }
}
