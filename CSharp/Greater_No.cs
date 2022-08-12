using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_No
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Enter 1st Num ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Num ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a<b)
            {
                Console.WriteLine("2nd Number is Greater");
            }
            else
            {
                Console.WriteLine("1st Number is Greater");
            }
            Console.ReadLine();
        }
    }
}
