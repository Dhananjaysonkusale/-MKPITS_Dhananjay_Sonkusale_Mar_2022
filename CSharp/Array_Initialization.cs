﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Initialization
{
    internal class Program
    {
        static void Main()
        {
            //creating a num array of 5 elements
            // int[] num = new int[5] { 1, 2, 3, 4, 5 };
            int[] num = { 1, 2, 3, 4, 5 };

            //display the values of array
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("num [ {0} ] = {1}", i, num[i]);
            }

        }
    }
}