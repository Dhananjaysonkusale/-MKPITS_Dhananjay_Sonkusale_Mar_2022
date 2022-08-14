using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Driven_For_Arithmatic_Operation_A7_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,n1,n2;
            double res;

            Console.WriteLine("Enter 1 for Addition : ");
            Console.WriteLine("Enter 2 for Subtraction : ");
            Console.WriteLine("Enter 3 for Multiplication : ");
            Console.WriteLine("Enter 4 for Division : ");
            Console.Write("Enter your choice : ");
            n = Convert.ToInt32(Console.ReadLine());


            switch (n)
            {
                case 1:
                    Console.Write("Enter 1st Number : ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter 2nd Number : ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    res=n1+n2;
                    Console.WriteLine("Addition : {0}", res);
                    break;
                case 2:
                    Console.Write("Enter 1st Number : ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter 2nd Number : ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    res = n1 - n2;
                    Console.WriteLine("Subtraction : {0}", res);
                    break;
                case 3:
                    Console.Write("Enter 1st Number : ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter 2nd Number : ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    res = n1 * n2;
                    Console.WriteLine("Multiplication : {0}", res);
                    break;
                case 4:
                    Console.Write("Enter 1st Number : ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter 2nd Number : ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    res = n1 / n2;
                    Console.WriteLine("Division : {0}", res);
                    break;
                default:
                    Console.WriteLine("Enter Valid Input");
                    break;
            }
        }
    }
}
