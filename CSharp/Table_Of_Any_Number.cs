﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_Of_Any_Number
{
    internal class Program
    {
        static void display(int a)
        {
            int res = 1;
            for (int i = 1; i <= 10; i++)
            {
                res = a * i;
                Console.WriteLine("{0}*{1}={2}",a,i,res);
            }
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Any Number : ");
            num=Convert.ToInt32(Console.ReadLine());
            display(num);

        }
    }
}
