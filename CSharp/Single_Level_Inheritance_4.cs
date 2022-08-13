using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Single_4
{
    public class Person
    {
        string name;
        string address;
        public void getPersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);

        }
    }
    public class Student : Person
    {
        int rno;
        int marks;
        public void getStudentData(int rno, int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            Console.WriteLine("Roll No : " + rno);
            Console.WriteLine("Mark : " + marks);

        }
    }

    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Student p1 = new Student();//creating object of child class
            p1.getPersonData("Dhananjay", "Nagpur");
            p1.getStudentData(34, 99);
            p1.displayStudentData();
            p1.displayPersonData();

        }
    }
}
