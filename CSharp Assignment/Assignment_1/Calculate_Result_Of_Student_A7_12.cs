using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Result_Of_Student_A7_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int rollno, p, c, ca, total;
            float per;
            Console.Write("Enter Your Roll No : ");
            rollno=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Name : ");
            name=Console.ReadLine();
            Console.Write("Enter Your Physics Mark : ");
            p=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Chemistry Mark : ");
            c=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Computer Application Mark : ");
            ca=Convert.ToInt32(Console.ReadLine());

            total = p + c + ca;
            per = (total / 300.0f) * 100.0f;

            Console.WriteLine("-------------Output------------");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Roll No : " + rollno);
            Console.WriteLine("Physics Mark : " + p);
            Console.WriteLine("Chemistry Mark : " + c);
            Console.WriteLine("Computer Application Mark : " + ca);
            Console.WriteLine("Total Mark Of Subject : " + total);
            Console.WriteLine("Percentage  : " + per);

            if (per >= 60 && per <= 70)
            {
                Console.WriteLine("Division : First Division");
            }
            else if (per >= 80)
            {
                Console.WriteLine("Division : Distinction");
            }
            else
            {
                Console.WriteLine("Result : Fail");
            }

        }
    }
}
