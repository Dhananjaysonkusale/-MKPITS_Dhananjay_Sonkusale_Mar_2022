using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_No_Odd_Or_Even_A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Enter Any Number : ");
            n1=Convert.ToInt32(Console.ReadLine());

            if(n1%2==0)
            {
                Console.WriteLine("Enter Number is Even ");
            }
            else
            {
                Console.WriteLine("Enter Number is Odd ");
            }
            Console.ReadLine();
        }
    }
}
