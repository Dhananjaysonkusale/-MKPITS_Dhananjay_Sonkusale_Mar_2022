using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Ex_3
{
    internal class Program
    {
        class Person
        {
            public string name = "Dhananjay";
        }
        class Employee : Person
        {
            public string name = "Akshay";
        }
        static void Main(string[] args)
        {
            Person p = new Employee();

            Console.WriteLine(p.name);
            
        }
    }
}
