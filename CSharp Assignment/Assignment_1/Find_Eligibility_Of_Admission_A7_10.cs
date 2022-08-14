using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Eligibility_Of_Admission_A7_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int math, phy, chem;
            Console.WriteLine("Enter Mathematics Mark : ");
            math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mathematics Mark : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mathematics Mark : ");
            chem = Convert.ToInt32(Console.ReadLine());
            int total = math + phy + chem;


            if (math >= 65 && phy >= 55 && chem >= 50)
            {
                Console.WriteLine("Eligible For Admission");
            }
            else if (total >= 180)
            {
                Console.WriteLine("Eligible For Admission");
            }
            else
            {
                Console.WriteLine("You are Not Eligible For Admission");
            }

        }
    }
}
