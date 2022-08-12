using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Bonus_By_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empname, designation;
            int bonus = 0;
            Console.WriteLine("Enter Employee Name : ");
            empname = Console.ReadLine();
            Console.WriteLine("Designation : ");
            designation = Console.ReadLine();
            switch (designation)
            {
                case "manager":
                    bonus = 10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 2000;
                    break;
                default:
                    Console.WriteLine("invalid designation");
                    break;
            }

            Console.WriteLine("Employee Name ={0} , Bonus = {1} ", empname, bonus);
            Console.ReadLine();
        }
    }
}
