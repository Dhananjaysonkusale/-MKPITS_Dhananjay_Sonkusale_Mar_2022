using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_EligibleforVote_Or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your Age = ");
            age=Convert.ToInt32(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("You Are Eligible For Vote");
            }
            else
            {
                Console.WriteLine("You Are Not Eligible For Vote");

            }
            Console.ReadLine();
        }
    }
}
