using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Method_Ex_1
{
    internal class Program
    {
        public class School
        {
            public virtual void Learning()
            {
                Console.WriteLine("School ");
            }
        }
        public class Student : School
        {
            public override void Learning()
            {
                Console.WriteLine("Student Learning");
            }
        }
        static void Main(string[] args)
        {
            School d = new Student();
            d.Learning();
        }
    }
}
