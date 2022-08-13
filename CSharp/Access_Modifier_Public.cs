using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier_Public
{
    class student
    {
        class PublicTest
        {
            public string name = "Dhananjay Sonkusale";
            public void Msg(string msg)
            {
                Console.WriteLine("Hello " + msg);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                PublicTest p = new PublicTest();
                // Accessing public variable
                Console.WriteLine("Hello " + p.name);
                // Accessing public function

                p.Msg("Akshay Pawar ");
            }
        }
    }
}