using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Of_Quadratic_Eq_A7_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double a, b, c;
                double d1, d2, n1, n2;
                Console.WriteLine("Enter The Value Of A,B,C...");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                {
                    n1 = -c / b;
                    Console.WriteLine("The Roots are Linear:", n1);
                }
                else
                {
                    d1 = (b * b) - (4 * a * c);
                    d2 = 2 * a;
                    if (d1 > 0)
                    {
                        Console.WriteLine("The Roots are Real And Distinct ");
                        n1 = (-b / d2) + (Math.Sqrt(d1) / d2);
                        n2 = (-b / d2) - (Math.Sqrt(d1) / d2);
                        Console.WriteLine("The Roots Are " + n1 + " and " + n2);
                    }
                    else if (d1 == 0)
                    {
                        Console.WriteLine("The Root are Repeated");
                        n1 = -b / d2;
                        Console.WriteLine("The Root is : " + n1);
                    }
                    else
                    {
                        Console.WriteLine("The Roots Are Imaginary ");
                        n1 = -b / d2;
                        n2 = ((Math.Sqrt((4 * a * c) - (b * b))) / d2);
                        Console.WriteLine("The Root 1 : " + n1 + " +i " + n2);
                        Console.WriteLine("The Root 2 :" + n1 + " -i " + n2);
                    }
                }
                Console.ReadLine();
            }
        }
    }
}

