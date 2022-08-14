using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Height_Of_Person_A7_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            Console.Write("Enter Height in cm : ");
            height=Convert.ToInt32(Console.ReadLine());
            if (height < 150)
            {
                Console.WriteLine("The Person is Dwarf");
            }
            else if(height >= 150 && height < 165)
            {
                Console.WriteLine("Average Height");
            }
            else if(height>=165)
            {
                Console.WriteLine("The Person is Tall");
            }
        }
    }
}
