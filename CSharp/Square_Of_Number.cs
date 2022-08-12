using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Of_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Any Number");
            num=Convert.ToInt32(Console.ReadLine());
            int Square = num * num;
            Console.WriteLine("Square = "+Square);
        }
    }
}
