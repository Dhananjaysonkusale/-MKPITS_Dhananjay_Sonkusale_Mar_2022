using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Field_Ex_5
{
    internal class Program
    {
        public class Account
        {

            public int accno;
            public string name;
            public static float rateOfInterest = 8.8f;
            public Account(int accno, string name)
            {
                this.accno = accno;
                this.name = name;
            }

            public void display()
            {
                Console.WriteLine(accno + " " + name + " " + rateOfInterest);
            }
        }
        static void Main(string[] args)
        {
            Account a1 = new Account(101, "Sonoo");
            Account a2 = new Account(102, "Mahesh");
            a1.display();
            a2.display();
        }
    }
}
