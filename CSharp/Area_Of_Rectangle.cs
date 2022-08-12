using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_Of_Three_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,num3 ,result;
            Console.WriteLine("Enter 1st Number : ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number : ");
            num3 = Convert.ToInt32(Console.ReadLine());
            result = num1 + num2 + num3;
            Console.WriteLine("Addition Of Three Number is = " + result);
            Console.ReadLine();
        }
    }
}
