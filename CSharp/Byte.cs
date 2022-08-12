using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b1;
            Console.WriteLine("enter bite ");
            b1 = Convert.ToByte(Console.ReadLine());   //range of a byte is 0 to -255
            Console.WriteLine("byte entered = " + b1);

            Console.ReadLine();
        }
    }
}
