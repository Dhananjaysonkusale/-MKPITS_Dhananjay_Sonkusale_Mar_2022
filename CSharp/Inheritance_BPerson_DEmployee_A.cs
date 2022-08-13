using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BPerson_DEmployee_A
{
    class Person
    {
        public string name;
        public string address;
        
        public void GetPersonData(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void ShowPersonData()
        {
            Console.WriteLine("Name : "+name);
            Console.WriteLine("Address : "+address);
        }
    }

    class Employee : Person
    {
        public int empno;
        public int salary;

        public void GetEmpData(int empno,int salary)
        {
            this.empno = empno;
            this.salary= salary;
        }
        public void ShowEmpData()
        {
            Console.WriteLine("Employee No : " + empno);
            Console.WriteLine("Salary : " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.GetPersonData("Dhananjay","Nagpur");
            emp.GetEmpData(34,45000);

            emp.ShowPersonData();
            emp.ShowEmpData();
        }
    }
}
