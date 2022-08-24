using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Ex_1
{
    internal class Program
    { 
        //Static Keyword Example
        void display()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            /*so p is an instance of class program and to access non static display method
            we access it through p instance*/
            p.display();
        }
    }
}
