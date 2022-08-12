using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_NoArg_NoRet_1
{
    
        class Myprogram
        {

            static int square()
            {
                int num;
                Console.WriteLine("Enter Any Number : ");
                num = Convert.ToInt32(Console.ReadLine());
                int sq = num * num;
                return sq;
           
            }
            static void Main(string[] args)
            {

                int r = square(); // calling the method display

                Console.WriteLine("Square  =  "+ r);

                Console.ReadLine();
            }
        }
    
}
