using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_TableOfNo_Using_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int res = 1;
            Console.Write("Enter Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                res = num * i;
                i++;
                Console.WriteLine("{0} * {1} = {2}", num, i, res);
            }
            Console.ReadLine();
        }
    }
}
