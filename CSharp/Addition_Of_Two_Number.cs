using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_Of_Two_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter 1st Number : ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number : ");
            num2=Convert.ToInt32(Console.ReadLine());
            int Result=num1 + num2;
            Console.WriteLine("Result = "+ Result);
            Console.ReadLine(); 
        }
    }
}
