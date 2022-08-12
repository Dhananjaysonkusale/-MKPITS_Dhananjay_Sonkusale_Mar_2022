using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_by_Value
{
    internal class Program
    {
        static void display(int num)
        {
            num++;
            Console.WriteLine("Num inside method = " + num);

        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Any Number");
            num = Convert.ToInt32(Console.ReadLine());
            display(num);

            Console.WriteLine("Num inside main = " + num);
        }
    }
}
