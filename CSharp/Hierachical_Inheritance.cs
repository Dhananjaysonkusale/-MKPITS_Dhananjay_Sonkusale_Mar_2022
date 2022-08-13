using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierachical_Inheritance
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

            Console.WriteLine("Marks : " + marks);

        }
    }
    public class Employee : Person
    {
        int salary;
        string designation;
        public void getEmployeeData(int salary, string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }
        public void displayEmployeeData()
        {
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Designation : " + designation);
        }
    }

    class TestInheritance
    {
        public static void Main(string[] args)
        {
            
            Student p1 = new Student();
            p1.getPersonData("Dhananjay","Nagpur");
            p1.getStudentData(34,78999);
            p1.displayPersonData();
            p1.displayStudentData();

           
            Employee e1 = new Employee();
            e1.getPersonData("Roshan","Nagpur");

            e1.getEmployeeData(49999,"Manager");
            e1.displayPersonData();
            e1.displayEmployeeData();

        }
    }
}
