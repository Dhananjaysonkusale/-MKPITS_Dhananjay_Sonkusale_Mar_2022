using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Ex_3
{
    abstract class account
    {
        public int acctno;
        public int bal = 1000;
        public abstract void deposit(int amt);

        public void showbalance()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\nAccount No. : XXXXXX{0} ", acctno);
            Console.WriteLine("Balance Amount : {0} \n", bal);
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
            int interest = 500;
            bal = bal + amt + interest;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Account No : ");
            int acctno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount to be deposited");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account type saving or current");
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
