﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calsulate_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, total;
            float per;
            string grade = "";
            Console.WriteLine("Enter subject 1 marks ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter subject 2 marks ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter subject 3 marks ");
            s3 = Convert.ToInt32(Console.ReadLine());
            total = s1 + s2 + s3;
            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("Total Marks = " + total);
            Console.WriteLine("Percentage = " + per);

            if (per >= 75)
            {
                grade = "Distinction";
            }
            else if (per >= 60 && per < 75)
            {
                grade = "First";
            }
            else
            {
                grade = "Fail";

            }
            Console.WriteLine("Grade = " + grade);
            Console.ReadLine();
        }
    }
}
