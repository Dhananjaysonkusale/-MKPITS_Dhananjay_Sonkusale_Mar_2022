using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Class_Account_Ex_7
{
    internal class Program
    {
        class Account
        {
            public int actno;
            public int balance = 1000;

            public virtual string deposit(int actno, int amount)
            {
                return "Deposit Method of Account Class";
            }
            public string showbalance()
            {
                return "Balance Amount : " + balance;

            }
        }

        class Current : Account
        {
            //overriding the base class deposit method
            public override string deposit(int actno, int amount)
            {
                this.actno = actno;
                balance = balance + amount;
                return "Amount Deposited Successfully Without Interest in Current Class";
            }
        }

        class Saving : Account
        {
            //overriding the base class deposit method
            public override string deposit(int actno, int amount)
            {
                this.actno = actno;
                int interest = 500;
                balance = balance + amount + interest;
                return "Amount Deposited successfully with interest in Saving class";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account No. : ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount to be Deposited ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------");

            Account act = new Current();
            string res = act.deposit(actno, amount);
            Console.WriteLine("Account No is : " + act.actno);
          
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.WriteLine("-----------------------------------------------");
            
            Console.Write("Enter Saving Account No. : ");
            int actno1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount to be Deposited : ");
            int amount1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------");

            Account sav = new Saving();
            string res1 = sav.deposit(actno1, amount1);
            Console.WriteLine("Account No is : " + sav.actno);
            Console.WriteLine(res1);
            res1 = sav.showbalance();
            Console.WriteLine(res1);
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
