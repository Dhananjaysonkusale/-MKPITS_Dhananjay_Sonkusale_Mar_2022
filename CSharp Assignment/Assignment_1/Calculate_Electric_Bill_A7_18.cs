using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Electric_Bill_A7_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id,unit;
            string name;
            Console.Write("Enter Your Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Your ID : ");
            id=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Unit : ");
            unit = Convert.ToInt32(Console.ReadLine());

            if(unit < 200)
            {
                float total = 1.20f * unit;
                Console.WriteLine(" ");
                Console.WriteLine("-------------Output--------------");
                Console.WriteLine("Name : " + name);
                Console.WriteLine("ID : " + id);
                Console.WriteLine("Unit : " + unit);
                Console.WriteLine("Amount Charges @Rs. 1.20 per unit : {0}",total);
            }
            else if(unit > 200 && unit < 400)
            {
                float total = 1.50f * unit;
                if (total > 400)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("-------------Output--------------");
                    Console.WriteLine("Name : " + name);
                    Console.WriteLine("ID : " + id);
                    Console.WriteLine("Unit : " + unit);
                    Console.WriteLine("Amount Charges @Rs. 1.50 per unit : {0}",total);
                    float scharge = total * 0.15f;
                    Console.WriteLine("Surchage Amount = {0}", scharge);
                    float totalbill = total + scharge;
                    Console.WriteLine("Net Amount Paid By the Customer : {0}",totalbill);
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("-------------Output--------------");
                    Console.WriteLine("Name : " + name);
                    Console.WriteLine("ID : " + id);
                    Console.WriteLine("Unit : " + unit);
                    Console.WriteLine("Amount Charges @Rs. 1.50 per unit : {0}", total);
                }
                
            }
            else if(unit > 400 && unit < 600)
            {
                Console.WriteLine(" ");
                Console.WriteLine("-------------Output--------------");
                Console.WriteLine("Name : " + name);
                Console.WriteLine("ID : " + id);
                Console.WriteLine("Unit : " + unit);
                float total = 1.80f * unit;
                Console.WriteLine("Amount Charges @Rs. 1.80 per unit : {0}",total);
                
                float scharge = total * 0.15f;
                Console.WriteLine("Surchage Amount = {0}", scharge);
                float totalbill = total + scharge;
                Console.WriteLine("Net Amount Paid By the Customer : {0}", totalbill);
            }
            else if(unit > 600)
            {
                Console.WriteLine(" ");
                Console.WriteLine("-------------Output--------------");
                Console.WriteLine("Name : " + name);
                Console.WriteLine("ID : " + id);
                Console.WriteLine("Unit : " + unit);
                float total = 2.00f * unit;
                Console.WriteLine("Amount Charges @Rs. 2.00 per unit : {0}",total);

                float scharge = total * 0.15f;
                Console.WriteLine("Surchage Amount = {0}", scharge);
                float totalbill = total + scharge;
                Console.WriteLine("Net Amount Paid By the Customer : {0}", totalbill);
            }

        }
    }
}
