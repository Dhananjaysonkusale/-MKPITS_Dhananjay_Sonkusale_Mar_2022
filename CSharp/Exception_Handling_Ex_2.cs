using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, num;
            Console.WriteLine("Enter Number 1st : ");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2nd : ");
            n=Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = num / n; //error will come here and program terminates
            }
            catch (Exception ee)
            {
                Console.WriteLine("Can not Divide By Zero ");
            }
            Console.WriteLine("Res = "+res);
            Console.WriteLine("bye");

        }
    }
}
