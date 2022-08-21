using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Array_into_Another_A9_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] a = new int[100];
            int [] b = new int[100];
            int n;
            Console.Write("Enter Number of Array Element :  ");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter Array Element {0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());                
            }
            
            for (int i = 0; i < n; i++)
            {
                b[i] = a[i];
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Element In 1st Array : ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}] : {1}", i, a[i]);
                
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Element In 2nd Array : ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}] : {1}", i, b[i]);                
            }
            Console.WriteLine("--------------------END-----------------------");
            Console.ReadLine();
        }
    }
}
