using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Driven_Various_Geomerical_Shape_A7_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, r, l, w, b, h;
            double area = 0;

            Console.WriteLine("Enter 1 for area of circle : ");
            Console.WriteLine("Enter 2 for area of rectangle : ");
            Console.WriteLine("Enter 3 for area of triangle : ");
            Console.Write("Enter your choice : ");
            n = Convert.ToInt32(Console.ReadLine());


            switch (n)
            {
                case 1:
                    Console.Write("Enter radius of the circle : ");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14 * r * r;
                    break;
                case 2:
                    Console.Write("Enter length  of the rectangle : ");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input  width of the rectangle : ");
                    w = Convert.ToInt32(Console.ReadLine());
                    area = l * w;
                    break;
                case 3:
                    Console.Write("Enter the base of the triangle :");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input the hight of the triangle :");
                    h = Convert.ToInt32(Console.ReadLine());
                    area = .5 * b * h;
                    break;
            }
            Console.WriteLine("The area is : {0}", area);
        }
    }
}
