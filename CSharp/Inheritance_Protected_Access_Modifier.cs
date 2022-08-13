using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Protected_AccessModifier
{
    public class Person
    {
        string name;
        string address;
        protected void getPersonData(string name, string address)
        {
            this.name = name;
            this.address = address;

        }
        protected void displayPersonData()
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
            getPersonData("Dhananjay", "Nagpur"); //calling base class method from derieved class
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("Roll No : " + rno);
            Console.WriteLine("Marks : " + marks);

        }
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Student p1 = new Student();//creating object of child class
                                       
            p1.getStudentData(34, 99);
            p1.displayStudentData();
            // p1.displayPersonData(); since testinhertance class in not derived class of person

        }

    }
}
