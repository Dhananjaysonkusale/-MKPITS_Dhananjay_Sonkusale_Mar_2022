﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Result_Using_Method
{
    internal class Program
    {
        static void display(int a,int b,int c)
        {
            string grade = " ";
            int total = a + b + c;
            Console.WriteLine("Total = " + total);

            float per = (total / 300.0f)*100.0f;
            Console.WriteLine("Percentage = "+ per);

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

        }
        static void Main(string[] args)
        {
            int s1,s2,s3;
            Console.WriteLine("Enter 1st Subject Mark : ");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Subject Mark : ");
            s2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Subject Mark : ");
            s3=Convert.ToInt32(Console.ReadLine());

            display(s1,s2,s3);


        }
    }
}
