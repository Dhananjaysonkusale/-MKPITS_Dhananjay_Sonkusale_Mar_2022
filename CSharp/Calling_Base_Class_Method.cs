using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Base_Class_Method
{
        class person
        {
            string name = "MKPITS";
            public void display()
            {
                Console.WriteLine(" base class field name = " + name);
            }

        }
        class student : person
        {
            string name = "Dhananjay";
            public void display()
            {
                //calling base class display method
                base.display();
                Console.WriteLine(" child class field name = " + name);
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                student s = new student();
                s.display();
            }
        }
            
}
