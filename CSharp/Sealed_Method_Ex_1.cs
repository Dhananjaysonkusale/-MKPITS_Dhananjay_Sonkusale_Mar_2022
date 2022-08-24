using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Method_Ex_1
{
    internal class Program
    {
        class person
        {
            public virtual void display()

            {
                Console.WriteLine("Hello from Class Person");
            }
        }
        class student : person
        {
            public string name;
            public sealed override void display()
            {
                Console.WriteLine("Hello");
            }
        }
        class parttime : student
        {
            /*
            public override void display() //error since sealed
            {
            Console.WriteLine("hello");
            }
            */
        }
        static void Main(string[] args)
        {
            parttime p = new parttime();
            p.display();
        }
    }
}
