﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Circumference_Of_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            Console.WriteLine("Enter radius Of Circle : ");
            radius = Convert.ToInt32(Console.ReadLine());
            float area = 3.14f * radius * radius;
            Console.WriteLine("area = " + area);
            float circ = 2 * 3.14f * radius;
            Console.WriteLine("circ = " + circ);
            Console.ReadLine();
        }
    }
}
