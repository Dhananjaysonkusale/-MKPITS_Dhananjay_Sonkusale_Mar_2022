﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptNo_And_PrintTableOfNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int res = 1;
            Console.Write("Enter Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                res = num * i;
                Console.WriteLine("{0} * {1} = {2}", num, i, res);
            }
            Console.ReadLine();
        }
    }
}