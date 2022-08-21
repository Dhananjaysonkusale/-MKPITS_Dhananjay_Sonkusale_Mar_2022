using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Of_Number_A8_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,fact=1;
            Console.Write("Enter Number : ");
            n=Convert.ToInt32(Console.ReadLine());

            for(int i = n; i > 0; i--)
            {
                fact=fact*i;
            }
            Console.WriteLine("Factorial = "+fact);
        }
    }
}
