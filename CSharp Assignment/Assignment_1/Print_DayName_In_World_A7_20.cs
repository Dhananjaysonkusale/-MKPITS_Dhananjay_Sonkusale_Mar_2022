using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_DayName_In_World_A7_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter Number Between 1 to 7 : ");
            n=Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Day : Monday");
                    break;
                case 2:
                    Console.WriteLine("Day : Tuesday");
                    break ;
                case 3:
                    Console.WriteLine("Day : Wednesday");
                    break ;
                case 4:
                    Console.WriteLine("Day : Thursday");
                    break ;
                case 5:
                    Console.WriteLine("Day : Friday");
                    break ;
                case 6:
                    Console.WriteLine("Day : Saturday");
                    break ;
                case 7:
                    Console.WriteLine("Day : Sunday");
                    break ;
                                      
                default:
                    Console.WriteLine("Enter Valid Input");
                    break;
            }
        }
    }
}
