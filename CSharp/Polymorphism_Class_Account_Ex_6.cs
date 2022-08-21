using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Class_Account_Ex_6
{
    internal class Program
    {
        class Account

        {
            public int actno;
            public int balance = 1000;

            public virtual string deposit(int actno, int amount)
            {
                return "Deposit method of account class";
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
                return "Amount deposited successfully in current class";
            }
        }
        static void Main(string[] args)
        {
            Account act = new Current();
            Console.Write("Enter Your Account No. : ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter amount to be Deposited : ");
            int amount = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("---------------OutPut---------------");

            string res = act.deposit(actno, amount);
            Console.WriteLine("Account no is : " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
        }
    }
}
