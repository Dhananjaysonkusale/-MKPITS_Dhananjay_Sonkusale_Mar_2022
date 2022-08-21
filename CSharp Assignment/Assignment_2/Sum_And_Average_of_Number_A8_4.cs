using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_And_Average_of_Number_A8_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            float avg;
            Console.WriteLine("Enter Any 10 Number : ");
            
            for(int i = 1; i <=10; i++)
            {
                Console.Write("Enter {0} Number : ", i);
                n=Convert.ToInt32(Console.ReadLine());
                sum = sum + n;
            }
            Console.WriteLine("The Sum Of 10 Number is  = " +  sum);

            avg = sum / 10.0f;
            Console.WriteLine("Average = {0}",avg);
        }
    }
}
