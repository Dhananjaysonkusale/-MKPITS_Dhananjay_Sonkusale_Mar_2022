using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_No_Equal_Or_Not_A7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Enter 1st Number : ");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd Number : ");
            n2=Convert.ToInt32(Console.ReadLine());
            if(n1==n2)
            {
                Console.WriteLine("{0} and {1} are Equal",n1,n2);
            }
            else
            {
                Console.WriteLine("Number are Not Equal");
            }

        }
    }
}
