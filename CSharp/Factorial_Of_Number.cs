using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Of_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("Enter Any Number : ");
            num=Convert.ToInt32(Console.ReadLine());

            for(int i = num; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial = " + fact);
            Console.ReadLine();
        }
    }
}
