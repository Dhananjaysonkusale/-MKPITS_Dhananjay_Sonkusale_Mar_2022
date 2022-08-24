using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("Enter 1st Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st Number : ");

            n = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = num / n; //error will come here and program terminates
            }
            catch (Exception ee)
            {
                Console.WriteLine("Catch Block is Executed");
            Console.WriteLine("Can Not Divide by Zero");
            }
            finally
            {
                Console.WriteLine("Finally Block is Zero");
                Console.WriteLine("Result = "+res);
            }
            Console.WriteLine("Bye");
        }
    }
}
