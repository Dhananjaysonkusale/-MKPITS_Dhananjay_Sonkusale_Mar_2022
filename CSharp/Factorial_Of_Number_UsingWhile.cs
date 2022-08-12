using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Of_Number_UsingWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int fact = 1;
            Console.Write("Enter Any Number : ");
            n=Convert.ToInt32(Console.ReadLine());
            int i = n;
            while ( i >0 )
            {
                fact = fact*i;
                i--;
            }
            Console.WriteLine("Factorial = " + fact);
            Console.ReadLine();
        }
    }
}
