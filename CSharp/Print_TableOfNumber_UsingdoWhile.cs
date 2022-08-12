using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_TableOfNo_Using_doWhileLoop
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
            do
            {
                res = num * i;
                i++;
                Console.WriteLine("{0} * {1} = {2}", num, i, res);
            } while (i <= 10);
            Console.ReadLine();
        }
    }
}
