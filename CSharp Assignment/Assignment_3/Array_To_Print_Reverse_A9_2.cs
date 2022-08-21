using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_To_Print_Reverse_A9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[1000];
            int n;
            Console.Write("Enter Number Of Element in Array : ");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");
                        
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Array Element {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Element in Array : ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}] = {1} ", i, a[i]);

            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Reverse Array : ");
            for (int i = n-1; i >=0; i--)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
        }
    }
}
