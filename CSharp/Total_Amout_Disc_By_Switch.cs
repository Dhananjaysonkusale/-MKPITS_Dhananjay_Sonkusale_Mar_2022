using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Total_Amount_A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pname;
            int cost, quantity, tamount;
  
            Console.Write("Enter Product Name : ");
            pname = Console.ReadLine();
            Console.Write("Enter Product Cost : ");
            cost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Quantity Of Product : ");
            quantity = Convert.ToInt32(Console.ReadLine());

            tamount = cost * quantity;
            Console.WriteLine("Total Amount = " + tamount);
            switch(tamount)
            {
                case 2000:
                    float discount = tamount - (tamount * 0.5f);
                    break;
                default:
                    float discount = tamount - (tamount * 0.1f);
                    Console.WriteLine("Total Amount After 10% Discount : " + discount);
                    break;

            }

            Console.ReadLine();

        }
    }
}
