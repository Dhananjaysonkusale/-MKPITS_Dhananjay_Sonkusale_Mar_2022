using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Of_Number_A8_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,n;
            
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Number is : {0} and cube of the {1} is :{2} ",i,i,(i * i * i));
            }
        }
    }
}
