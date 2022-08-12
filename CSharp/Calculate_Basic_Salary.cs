using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_basic_salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int emid,sallary;
            float hra,da,total;
            
            string name;
            Console.Write("Enter Employee ID : ");
            emid= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            name= Convert.ToString(Console.ReadLine());
            Console.Write("Enter Sallary : ");
            sallary = Convert.ToInt32(Console.ReadLine());

            hra = sallary * 0.32f;
            da = sallary * 0.45f;
            total = sallary + hra + da;
            Console.WriteLine("Employee Name :"+name);
            Console.WriteLine("Employee ID :"+emid);
            Console.WriteLine("HRA = " + hra);
            Console.WriteLine("DA = " + da);
            Console.WriteLine("Total Sallary = " + total);
            Console.ReadLine();

        }
    }
}
