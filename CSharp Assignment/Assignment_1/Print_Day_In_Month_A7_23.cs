using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Day_In_Month_A7_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter Any Number Between 1 to 12 : ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1: Console.WriteLine("Day : 31"); break;
                case 2: Console.WriteLine("Day : 28"); break;
                case 3: Console.WriteLine("Day : 31"); break;
                case 4: Console.WriteLine("Day : 30"); break;
                case 5: Console.WriteLine("Day : 31"); break;
                case 6: Console.WriteLine("Day : 30"); break;
                case 7: Console.WriteLine("Day : 31"); break;
                case 8: Console.WriteLine("Day : 31"); break;
                case 9: Console.WriteLine("Day : 30"); break;
                case 10: Console.WriteLine("Day : 31"); break;
                case 11: Console.WriteLine("Day : 30"); break;
                case 12: Console.WriteLine("Day : 31"); break;
                default: Console.WriteLine("Enter Valid Input"); break;
            }
        }
    }
}
