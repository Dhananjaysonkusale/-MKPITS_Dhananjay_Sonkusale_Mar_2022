using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
            
        }
        //in method overloading argument should be different otherwise it will show an error
        static int Add(int a, int b, int c) 
        {
            return a + b + c;
        }
        static void Main()
        {
            Console.WriteLine(Add(1, 2));
            
            Console.WriteLine(Add(1, 2, 3));

        }
        
    }
}
