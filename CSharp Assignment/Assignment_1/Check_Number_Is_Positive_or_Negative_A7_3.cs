using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Number_Is_Positive_or_Negative_A7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Any Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("{0} is a Positive Number ",num);
            }
            else
            {
                Console.WriteLine("{0} is a Negative Number ",num);
            }
        }
    }
}
