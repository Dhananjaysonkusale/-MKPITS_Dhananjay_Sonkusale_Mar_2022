using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Class_Acoount_Ex_4
{
    internal class Program
    {
        class Account
        {
            public int AccNo;
            public int Balance=5000;

            public string deposite (int AccNo,int Amount)
            {
                return "Deposit method of account class";
            }
            public string showbalance()
        }
        static void Main(string[] args)
        {
        }
    }
}
