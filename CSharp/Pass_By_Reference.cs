using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_By_Reference
{
    internal class Program
    {
        static void display(ref int num)
        {
            num++;
            Console.WriteLine("Num inside method = " + num); //6

        }

        static void Main(string[] args)
        {
            int num = 5;
            display(ref num);

            Console.WriteLine("Num inside main = " + num); //6
        }
    }
}
