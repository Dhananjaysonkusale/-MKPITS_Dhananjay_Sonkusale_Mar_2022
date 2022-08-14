using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Number_Is_Odd_Or_Not_A7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Any Number : ");
            num=Convert.ToInt32(Console.ReadLine());
            if(num%2 != 0)
            {
                Console.WriteLine("{0} Number is Odd ",num);
            }
            else
            {
                Console.WriteLine("{0} Number is Even", num);
            }
        }
    }
}
