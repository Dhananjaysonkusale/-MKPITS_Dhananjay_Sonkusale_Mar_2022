using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_To_Print_Number_A9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 10 Element in Array : ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter Array Element {0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Element in Array : ");
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("a[{0}] = {1} ",i, a[i]);
            }
            Console.WriteLine();
        }
    }
}
