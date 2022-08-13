using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance_2
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

    public class ParttimeEmployee : Employee
    {
        int no_of_hours;
        public void getParttimeEmployeeData(int no_of_hours)
        {
            
            this.no_of_hours = no_of_hours;

        }
        public void displayparttimeEmployeeData()
        {
            
            Console.WriteLine("No of hours : " + no_of_hours);

        }
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {

            ParttimeEmployee p1 = new ParttimeEmployee();//creating object of child class\
            p1.getPersonData("Dhananjay", "Nagpur");
            p1.getEmployeeData(45000, "Manager");
            p1.getParttimeEmployeeData(5);
            p1.displayPersonData();
            p1.displayEmployeeData();
            p1.displayparttimeEmployeeData();

        }
    }
}
