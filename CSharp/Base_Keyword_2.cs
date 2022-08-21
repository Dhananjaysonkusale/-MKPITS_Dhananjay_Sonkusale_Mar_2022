using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Keyword_2
{
    internal class Program
    {
        public class Human
        {
            public void Dance()
            {

                Console.WriteLine("Boys Are Dancing ");
            }
        }

        public class Gender : Human
        {
            public void Dance()
            {
                base.Dance(); //this will class base class method eat
                Console.WriteLine("Girls Are Dancing");
            }

        }
        static void Main(string[] args)
        {
            Gender g = new Gender();
            g.Dance();
        }
    }
}
