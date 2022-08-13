using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inheritance
{
    //creating a base class person
    class person
    {
        public string name;
    }
    //creating a derieved class student
    class student : person
    {
        public int rno;
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.rno = 34;
            s.name = "Dhananjay";
            Console.WriteLine("Roll No : " + s.rno);
            Console.WriteLine("Name : " + s.name);
        }
    }
}