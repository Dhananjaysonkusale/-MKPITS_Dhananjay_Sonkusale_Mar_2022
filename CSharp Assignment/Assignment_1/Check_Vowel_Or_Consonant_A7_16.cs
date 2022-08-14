using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Vowel_Or_Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("Enter Any Alphabet : ");
            a = Convert.ToChar(Console.ReadLine());

            if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
            {
                Console.WriteLine("Entered Alphabet is Vowel !");
            }
            else if (a == 'A' || a == 'E' || a == 'I' || a == 'O' || a == 'U')
            {
                Console.WriteLine("Entered Alphabet is Vowel !");
            }
            else
            {
                Console.WriteLine("Entered Alphabet is Consonant ");
            }
            Console.ReadLine();
        }
    }
}
