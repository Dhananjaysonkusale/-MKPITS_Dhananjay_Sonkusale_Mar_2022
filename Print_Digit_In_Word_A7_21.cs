using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Digit_In_Word_A7_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter Any Number Between 0 to 10 : ");
            n=Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 0: Console.WriteLine("Zero");break;
                case 1: Console.WriteLine("One");break;
                case 2: Console.WriteLine("Two");break;
                case 3: Console.WriteLine("Three");break;
                case 4: Console.WriteLine("Four");break;
                case 5: Console.WriteLine("Five");break;
                case 6: Console.WriteLine("Six");break;
                case 7: Console.WriteLine("Seven");break;
                case 8: Console.WriteLine("Eight");break;
                case 9: Console.WriteLine("Nine");break;
                case 10: Console.WriteLine("Ten");break;
                default:Console.WriteLine("Enter Valid Input");break;
            }
        }
    }
}
