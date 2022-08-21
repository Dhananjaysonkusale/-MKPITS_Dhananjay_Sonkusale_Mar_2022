using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Number_Pattern_Pyramid_A8_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r, i, j;
            Console.Write("Enter Number of rows : ");
            r = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= r; i++)
            {
                for (j = r; j >=i; j--)
                {
                    Console.Write(" ");                    
                }
                int count = 1;
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(count + " ");
                    count=count+1;
                }
                Console.WriteLine();
            }
        }
    }
}
