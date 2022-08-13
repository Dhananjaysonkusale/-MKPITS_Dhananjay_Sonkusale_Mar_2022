using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier_Private
{
    class student
    {
        protected string name;
        public void getdata()
        {
            name = "Dhananjay";
            Console.WriteLine("Name : " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            //s.name = "Dhananjay";
            s.getdata();
        }

    }
}
