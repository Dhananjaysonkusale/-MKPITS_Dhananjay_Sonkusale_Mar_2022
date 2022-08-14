using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Triangle_Formed_A7_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,total;
            Console.Write("Enter 1st Side Of Triangle : ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd Side Of Triangle : ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd Side Of Triangle : ");
            c=Convert.ToInt32(Console.ReadLine());

            total = a + b + c;
            if(total == 180)
            {
                Console.WriteLine("Triangle Can Be Formed ");
            }
            else
            {
                Console.WriteLine("Triangle Can Not Formed ");
            }
        }
    }
}
