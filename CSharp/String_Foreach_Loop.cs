using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_For_each_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example of foreach loop
            //create an array of 5 element
            string[] num = new string[8];

            num[0] = "Dhananjay";
            num[1] = "Akshay";
            num[2] = "Krunal";
            num[3] = "Shubham";
            num[4] = "Tanmay";
            num[5] = "Aniket";
            num[6] = "Amit";
            num[7] = "Nandu";
            //using foreach loop to iterate over the elements of an array
            foreach (string i in num)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
