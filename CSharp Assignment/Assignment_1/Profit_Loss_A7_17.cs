using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit_Loss_A7_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c,s,res;
            Console.Write("Enter Cost Price : ");
            c=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Selling Price : ");
            s=Convert.ToInt32(Console.ReadLine());

            if (s > c)
            {
                res = s - c;
                Console.WriteLine("You can book your profit amount = {0} ",res);
            }
            else if(c > s)
            {
                res = c - s;
                Console.WriteLine("You Loss your amount = {0} ", res);
            }
            else
            {
                Console.Write("No Profit No Loss");
            }
        }
    }
}
