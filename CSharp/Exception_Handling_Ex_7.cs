﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            try
            {
                Console.WriteLine("Enter Age : ");
                age = Convert.ToInt32(Console.ReadLine());
                //if the user enters age below 18 then throw the exception
                if (age < 18)
{
                    throw new Exception(" age should be greater or equal to 18 :");
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine(" enter age 18 or greater than 18 ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("finally block is executing ");
                Console.WriteLine(" Age = "+age);
            }
            Console.WriteLine("Bye");
        }
    }
}
