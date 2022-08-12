using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Bonus_A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int emid, sallary, bonus;
            string name, des;

            Console.Write("Enter Employee ID : ");
            emid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Designation : ");
            des = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Employee Name :" + name);
            Console.WriteLine("Employee ID :" + emid);
            switch(des)
            {
                case "manager":
                    Console.WriteLine("Bonus = 10000");
                    break;

                case "clerk":
                    Console.WriteLine("Bonus = 5000");
                    break;
                case "peon":
                    Console.WriteLine("Bonus = 2000");
                    break;

                default: 
                    Console.WriteLine("Invalid Input ");
                    break;

            }

            Console.ReadLine();
        }
    }
}
