using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Ex_3
{
    internal class Program
    {
        class student
        {
            public static void display()
            {
                Console.WriteLine(" Hello.......");
            }
            public void sayhi()
            {
                Console.WriteLine(" Hi......");
            }
        }
        static void Main(string[] args)
        {
            student.display();
            // student.sayhi();// error
            student s = new student();
            s.sayhi();
        }
    }
}
