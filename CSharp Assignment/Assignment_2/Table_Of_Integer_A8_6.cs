using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_Of_Integer_A8_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int res = 1;
            Console.Write("Enter A Number : ");
            n=Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                res = n * i;
                Console.WriteLine("{0}*{1} ={2}",n,i,res);
            }
        }
    }
}
