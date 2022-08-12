using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2;
            char op;
            int res = 0;
            Console.WriteLine("Enter 1st num ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd num ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator");
            op = Convert.ToChar(Console.ReadLine());
            if (op == '+')
            {
                res = s1 + s2;

            }
            else if (op == '-')
            {
                res = s1 - s2;

            } 
            else if (op == '*')
            {

                res = s1 * s2;
            }
            else
            {
                Console.WriteLine("invalid operator");

            }

            Console.WriteLine("result = " + res);
            Console.ReadLine();
        }
    }
}
