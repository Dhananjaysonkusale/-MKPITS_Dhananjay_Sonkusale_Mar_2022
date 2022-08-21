using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Ex_1
{
    abstract class account
    {
        public abstract void deposit();

    }
    class saving : account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello from saving depsoit method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // account act = new account(); //error
            account act = new saving();
            act.deposit();

        }

    }
}
