using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Greater_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.Write("Enter 1st number : ");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            n2=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number : ");
            n3=Convert.ToInt32(Console.ReadLine());
            if(n1>n2 && n1>n3)
            {
                Console.WriteLine("1st Number is Greater !");
            }
            else if(n2>n1 && n2>n3)
            {
                Console.WriteLine("2nd Number is Greater !");
            }
            else
            {
                Console.WriteLine("3rd Number is Greater !");
            }
            Console.ReadLine();
        }
    }
}
