using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BPerson_DStudent
{
    public class Person
    {
        public string name;
        public string address;
    }
    public class Student : Person
    {
        public int rno;
        public int marks;
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Student p1 = new Student();//creating object of child class\
            p1.rno = 34;
            p1.name = "Dhananjay Sonkusale";
            p1.address = "Nagpur";
            p1.marks = 433;

            Console.WriteLine("Roll No : " + p1.rno);
            Console.WriteLine("Name : " + p1.name);
            Console.WriteLine("Address: " + p1.address);
            Console.WriteLine("Marks: " + p1.marks);

        }
    }
}
