using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Ex_4
{
    internal class Program
    {
        abstract class account
        {
            public int acctno;
            public int bal = 1000;
            public abstract void deposit(int amt);

            public void showbalance()
            {
                Console.WriteLine("\nAccount No : {0} \nAmount Balance : {1} \n", acctno, bal);
            }
        }
        class current : account
        {
            public override void deposit(int amt)
            {
                bal = bal + amt;

            }
        }
        class saving : account
        {
            public override void deposit(int amt)
            {
                int interest = 200;
                bal = bal + amt + interest;

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account No : ");
            int acctno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited : ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type saving or current : ");
            string acttype = Console.ReadLine();
            account act = null;
            if (acttype == "saving")
            {
                act = new saving();
            }
            else if (acttype == "current")
            {
                act = new current();
            }
            act.acctno = acctno;
            act.deposit(amt);
            act.showbalance();
        }
    }
}
    

