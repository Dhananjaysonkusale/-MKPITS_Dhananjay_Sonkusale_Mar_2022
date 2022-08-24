using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter Number 1st : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2nd : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = n1 / n2;
            }
            catch (Exception ee) // code will execute only if run time error occurs
            {
                Console.WriteLine("catch block is executing ");
            Console.WriteLine(ee.ToString());
            }
            finally //code will execute whehter error occurs or not
            {
                Console.WriteLine("finally block is executing ");
                Console.WriteLine("Result = " +res);
            }
            Console.WriteLine("Bye");
        }
    }
}
