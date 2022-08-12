using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_NoArg_NoRet_1
{
    internal class Program
    {
        class Myprogram
        {

            static void square()
            {
                int num;
                Console.WriteLine("Enter Any Number : ");
                num = Convert.ToInt32(Console.ReadLine());
                int sq = num * num;
                Console.WriteLine("Square Of {0} is = {1} ", num, sq);
            }
            static void Main(string[] args)
            {
                square(); // calling the method display
                Console.WriteLine("The End");
                Console.ReadLine();
            }
        }
    }
}
