using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Ex_2
{
    abstract class account
    {
        public abstract void deposit(); //abstract method
        //abstract class declared abstract and has no body is called abstract method.
        //abstract method is internally a virtual method so it can be overridden by the derived class.
        public void showbalance() //non abstract method
        {
            Console.WriteLine("Balance Method ");
        }

    }
    class saving : account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello From saving deposit method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // account act = new account();
            // It Will Throw Error Because we Can't Create Instance Of Abstract/Interface Class

            account act = new saving();

            act.deposit();
            act.showbalance();

        }

    }
}
