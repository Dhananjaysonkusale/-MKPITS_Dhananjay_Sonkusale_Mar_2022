using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Ex_13
{
    internal class Program
    {
        class ageexception : ApplicationException
        {
            public ageexception(string message) : base(message)
            {
            }
        }
        class age
        {
            public int age1;
            public void checkage(int age1)
            {
                this.age1 = age1;
                if (age1 < 18)
                {
                    throw (new ageexception("You are not elegible to vote"));
                }
                else
                {
                    Console.WriteLine("You are eligible to vote ");
                }
            }
        }
        static void Main(string[] args)
        {
            age a = new age();
            Console.WriteLine("Enter your age : ");
            int num = Convert.ToInt32(Console.ReadLine());
            try
            {
                a.checkage(num);
            }
            catch (ageexception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Bye ");
        }
    }
}
