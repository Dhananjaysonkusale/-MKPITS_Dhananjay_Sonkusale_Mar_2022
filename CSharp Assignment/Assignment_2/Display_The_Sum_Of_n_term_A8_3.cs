using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_The_Sum_Of_n_term_A8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            Console.Write("Enter Number You Want : ");
            n=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Natural Number {0} is ", n);
            for (int i = 0; i <= n; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------Sum----------------------");
            for (int i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
