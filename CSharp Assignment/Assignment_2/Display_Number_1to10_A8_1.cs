using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Number_1to10_A8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Number From 1 to 10 : ");
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(" " + i);
                //Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
