using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ex_3
{
    internal class Program
    {
        interface bank
        {
            string deposit(int actno, int amt);
        }
        class account
        {
            public int actno;
            public int bal = 1000;
        }
        class saving : account, bank
        {

            public string deposit(int actno, int amt)
            {
                this.actno = actno;
                bal = bal + amt;
                return "Deposited successfully successfully ,bal is " + bal;
            }
        }
        static void Main(string[] args)
        {
            bank b;
            b = new saving();
            string str = b.deposit(1, 200);
            Console.WriteLine(str);
        }   
    } 
} 
