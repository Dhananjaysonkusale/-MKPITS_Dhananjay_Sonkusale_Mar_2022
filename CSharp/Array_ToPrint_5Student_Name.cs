﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_To_Print_5_Student_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] name = new string[5];
            

            for(int i = 0; i < 5; i++)
            {
            Console.Write("Enter Student Name :");
                name[i] = Console.ReadLine();

                
                
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n"+name[i]);
            }


                Console.ReadLine();
        }
    }
}
