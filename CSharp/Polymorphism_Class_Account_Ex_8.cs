using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Class_Account_Ex_8
{
    internal class Program
    {
        class Account
        {
            public int actno;
            public int balance = 1000;

            public virtual string deposit(int actno, int amount)
            {
                return "deposit method of account class";
            }
            public string showbalance()
            {
                return "balance amount : " + balance;
            }
        }

        class Current : Account
        {
            //overriding the base class deposit method
            public override string deposit(int actno, int amount)
            {
                this.actno = actno;
                balance = balance + amount;
                return "amount deposited successfully without interest in current class";
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
                return "amount deposited successfully with interest in saving class";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account No : ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount to be Deposited : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type (saving or currrent) : ");
            string acttype = Console.ReadLine();

            Account act = null;
            if (acttype == "saving")
            {
                act = new Saving();
            }
            else if (acttype == "current")
            {
                act = new Current();
            }
            string res = act.deposit(actno, amount);
            Console.WriteLine("Account no is xxxx xx" + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
        }
    }
}
