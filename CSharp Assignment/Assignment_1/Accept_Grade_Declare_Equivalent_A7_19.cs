using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accept_Grade_Declare_Equivalent_A7_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("Enter a Grade : ");
            a =Convert.ToChar( Console.ReadLine());

            if(a=='E'|| a == 'e')
            {
                Console.WriteLine("You have chosen : Excellent");
            }

            else if(a=='V'|| a == 'v')
            {
                Console.WriteLine("You have chosen : Very Good");
            }

            else if(a=='G'|| a == 'g')
            {
                Console.WriteLine("You have chosen : Good");
            }

            else if(a=='A'|| a == 'a')
            {
                Console.WriteLine("You have chosen : Average");
            }
            else if(a=='F'|| a == 'f')
            {
                Console.WriteLine("You have chosen : Fail");
            }

        }
    }
}
