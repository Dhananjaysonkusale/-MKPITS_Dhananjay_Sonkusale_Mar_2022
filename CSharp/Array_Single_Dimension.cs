using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Single_Dimension
{
    internal class Program
    {
        static void Main()
        {
            //creating a num array of 5 elements
            int[] num = new int[5];
            Console.WriteLine("Enter an Array : ");
            for (int i = 0; i < 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            //display the values of array
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("num [ {0} ] = {1}", i, num[i]);
            }
        }
    }
}
