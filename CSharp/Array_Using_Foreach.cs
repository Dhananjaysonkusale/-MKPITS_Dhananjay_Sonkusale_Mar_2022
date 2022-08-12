using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Using_For_each_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            num[0] = 33;
            num[1] = 22;
            num[2] = 31;
            num[3] = 54;
            num[4] = 36;
            //using foreach loop to iterate over the elements of an array
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
