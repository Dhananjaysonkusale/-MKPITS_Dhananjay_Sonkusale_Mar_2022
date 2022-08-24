using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ex_1
{
    internal class Program
    {
        interface shape
        {
            void draw();

        }
        class rectangle : shape
        {
            public void draw()
            {
                Console.WriteLine("Draw method of Rectangl class");
            }
        }
        class circle : shape

        {
            public void draw()
            {
                Console.WriteLine("Draw method of Circle class");
            }
        }
        static void Main(string[] args)
        {
            shape s = new rectangle();
            s.draw();
            s = new circle();
            s.draw();
        }
    }
}
