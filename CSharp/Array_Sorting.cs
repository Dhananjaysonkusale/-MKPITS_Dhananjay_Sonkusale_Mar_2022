﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sorting
{
    internal class Program
    {
        static void Main()
        {
            //creating a num array of 2 rows and 3 colums
            // int[] num = new int[5] { 1, 2, 3, 4, 5 };
            int[] num = { 3, 5, 1, 2, 4 };
            Array.Sort(num);

            //display the values of array
            for (int i = 0; i < num.Length; i++)
            {

                Console.Write(num[i] + "\t");

            }

        }
    }
}
