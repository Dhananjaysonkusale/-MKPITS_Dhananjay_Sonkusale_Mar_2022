using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Triangle_A7_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.Write("Enter 1st Side Of Triangle : ");
            a=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd Side Of Triangle : ");
            b=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 3rd Side Of Triangle : ");
            c=Convert.ToInt32(Console.ReadLine());

            if(a==b && b==c)
            {
                Console.WriteLine("This is an equilateral triangle ");
            }
            else if(a==b || a==c|| b==c)
            {
                Console.WriteLine("This is an isosceles triangle ");
            }
            else
            {
                Console.WriteLine("This is a scalene triangle");
            }

        }
    }
}
