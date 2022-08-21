using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Number_Pattern_RepeatNum_A8_11
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
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0} ",i);                    
                }
                Console.WriteLine();
            }
        }
    }
}
