using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_1st_Ten_Number_A8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("1st 10 Natural Number : ");
            for(int i = 0; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 0; i <=10 ; i++)
            {
                sum= sum + i;               
            }
            Console.WriteLine("Sum of 1st 10 Number is = {0} ",sum);
        }
    }
}
