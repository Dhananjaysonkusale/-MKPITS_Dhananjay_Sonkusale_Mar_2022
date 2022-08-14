using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Leap_Year_A7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter Year : ");
            year=Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("{0} is a Leap Year ",year);
            }
            else
            {
                Console.WriteLine("{0} is Not a Leap Year ",year);

            }
        }
    }
}
