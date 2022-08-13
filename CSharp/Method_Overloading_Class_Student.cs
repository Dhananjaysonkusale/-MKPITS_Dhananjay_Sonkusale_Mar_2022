using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Class_Students
{
    class Students
    {
        int rollno,fees;
        string course, name;
        
        public void getdata(int rollno)
        {
            this.rollno = rollno;
         
        }
        public void getdata(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
            
        }
        public void getdata(int rollno,string name,string course)
        {
            this.rollno=rollno;
            this.name=name;
            this.course=course;

        }
        public void getdata()
        {
            Console.WriteLine("Enter Student RollNo : ");
            rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Fees : ");
            fees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course : ");
            course = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("Roll No : " + rollno);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Fees : " + fees);
            Console.WriteLine("Coure : " + course);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Student with one parameter---------");
            Students s4 = new Students();
            s4.getdata(36);
            s4.display();
            
            Console.WriteLine("-------Student with two parameter---------");
            Students s2 = new Students();
            s2.getdata(34, "Dhananjay");
            s2.display();

            Console.WriteLine("-------Student with three parameter---------");
            Students s3 = new Students();
            s3.getdata(35, "Sanjiv","ETC" );
            s3.display();

            Console.WriteLine("-------Student with four parameter---------");
            Students s = new Students();
            s.getdata();
            s.display();

            Console.ReadLine();
        }
    }
}
