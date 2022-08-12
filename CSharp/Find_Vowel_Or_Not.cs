using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Vowel_Or_Not_A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("Enter Letter : ");
            a = Convert.ToChar(Console.ReadLine());

            if (a == 'a' || a == 'e' || a == 'i' || a == 'o'|| a=='u')
            {
                Console.WriteLine("Enter Letter is Vowel !");
            }
            else if (a == 'A' || a == 'E' || a == 'I' || a == 'O'|| a=='U')
            {
                Console.WriteLine("Enter Letter is Vowel !");
            }
            else
            {
                Console.WriteLine("Enter Letter is Not Vowel");
            }
            Console.ReadLine();
        }
    }
}
