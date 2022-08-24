using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Ex_7
{
    internal class Program
    {
        abstract class Account
        {
            public int actno;
            public int balance = 1000;
            //creating abstract method deposit
            public abstract string deposit(int actno, int amount);

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

                return "\nAmount deposited successfully without interest in current class";
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
                return "\nAmount deposited successfully with interest in saving class";
            }
        }
        static void Main(string[] args)
        {
            //runtime polymorphism : base class reference variable having instance of derieved class current

            Console.WriteLine("Enter account No. :");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account type (saving or currrent) : ");
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
            Console.WriteLine("Account No is : " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
        }
    }
}
