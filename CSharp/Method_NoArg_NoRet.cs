using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_No_Arg_No_Return
{
    class Program
    {
        static void display()
        {
            Console.WriteLine("hello from display method");
        }
        static void Main(string[] args)
        {
            display();
            Console.WriteLine("bye");
            Console.ReadLine();
        }
        
    }
}