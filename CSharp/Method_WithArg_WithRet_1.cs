using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_NoArg_NoRet_1
{
    internal class Program
    {
        class Myprogram
        {

            static int square(int num)
            {
                if (num>4)
                {
                    int sq = num * num;
                    return sq;
                }
                else
                {
                    return 0;
                }
                
                
            }
            static void Main(string[] args)
            {
                int num;
                Console.WriteLine("Enter Any Number : ");
                num = Convert.ToInt32(Console.ReadLine());

                int r = square(num); 
                
                Console.WriteLine("Square Of {0} is = {1} ", num, r);

                Console.ReadLine();
            }
        }
    }
}
