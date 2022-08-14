using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eligible_For_Vote_A7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter Your Age : ");
            age=Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote");
            }
            else
            {
                Console.WriteLine("Sorry! You are Not eligible for casting your vote");
            }
        }
    }
}
