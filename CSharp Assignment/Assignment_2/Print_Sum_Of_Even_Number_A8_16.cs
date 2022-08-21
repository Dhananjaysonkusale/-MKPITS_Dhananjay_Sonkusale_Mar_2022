using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Sum_Of_Even_Number_A8_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.Write("Enter Any Number  = ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int a = 2 * i;
                Console.WriteLine("{0}", a);
                sum = sum + a;
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
