using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class_Ex_2
{
    internal class Program
    {
        abstract class person
        {
            public string name;
        }
        class student : person
        {
            public int rno;
        }
        sealed class parttimestudent : student
        {
            public int hours;
        }
        /*
        class newstudent : parttimestudent //error

        {

        }
        */
        static void Main(string[] args)
        {
            // person p = new person(); //error
            parttimestudent p = new parttimestudent();
            p.rno = 22;
            p.name = "Dhananjay";
            p.hours = 5;
            Console.WriteLine("Roll No: " + p.rno);
            Console.WriteLine("Name : " + p.name);
            Console.WriteLine("Hours : " + p.hours);
        }
    }
}
