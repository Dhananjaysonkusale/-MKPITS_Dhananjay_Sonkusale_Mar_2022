using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_All_Element_in_Array_A9_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[1000];
            int n,sum=0;
            Console.Write("Enter Number Of Element in Array : ");
            n = Convert.ToInt32(Console.ReadLine());
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
            for (int i = 0; i < n; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Sum Of All Element in Array is = "+ sum);
            Console.WriteLine("----------------------------------------------------");

        }
    }
}
