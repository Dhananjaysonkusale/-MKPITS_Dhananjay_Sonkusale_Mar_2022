using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Statement2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Any Number : ");
            num= Convert.ToInt32(Console.ReadLine());


            if (num % 2 == 0) goto even;
            Console.WriteLine("ODD");
            goto end;

        even:
            Console.WriteLine("No is Even");
            goto end;
        end:
            Console.WriteLine("THE END");
            Console.ReadLine();
        }
        
    }
}
