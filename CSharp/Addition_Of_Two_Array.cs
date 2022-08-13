using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Addition_of_Two_Array
{
    internal class Program
    {
        static void Main()
        {

            int i, j, n;
            int[,] arr1 = new int[3,3];
            int[,] arr2 = new int[3,3];
            int[,] arr3 = new int[3,3];
            
            
            Console.WriteLine("Enter first Array : ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter Second Array : ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("\n First Array is: ");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }
            }
            Console.WriteLine("\n Second Array is: ");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            
            Console.WriteLine("\n Addition of two Array: ");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", arr3[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}
