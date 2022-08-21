using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Class_Account_Ex_5
{
    internal class Program
    {
        class Account
        {
            public int actno;
            public int balance = 2000;

            public virtual string deposit(int actno, int amount)
            {
                return "Deposit method of account class";
            }
            public string showbalance()
            {
                return "Balance amount : " + balance;
            }
        }

        class Current : Account
        {

            //overriding the base class deposit method
            public override string deposit(int actno, int amount)
            {
                this.actno = actno;
                balance = balance + amount;
                return "Amount Deposited successfully in current Class";
            }
        }
        static void Main(string[] args)
        {
            //runtime polymorphism : base class reference variable having instance of derieved class current
            Account act = new Current();
            string res = act.deposit(123, 2000);
            Console.WriteLine("Account no is " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
        }
    }
}
