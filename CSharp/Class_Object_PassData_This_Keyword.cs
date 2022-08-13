using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_PassData_This_Keyword
{
    class Employee
    {
        public int empid;
        public string empname;
        public int empsal;

        public void getdata(int empid, string empname, int empsal)
        {
            // this. keyword is use to create instance of object
            this.empid=empid ;
            this.empname=empname ;
            this.empsal=empsal;

        }
        public void showdata()
        {
            Console.WriteLine("Employee ID : " + empid);
            Console.WriteLine("Employee ID : " + empname);
            Console.WriteLine("Employee ID : " + empsal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an object(instance) of employee class
            //syntax classname objectname =new classname();
            Employee emp = new Employee();
            Console.WriteLine("Enter Employee ID : ");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            string empname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Sallary : ");
            int empsal = Convert.ToInt32(Console.ReadLine());

            emp.getdata(empid, empname, empsal);

            emp.showdata();
            Console.ReadLine();
        }
    }
}
