using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    internal class Program
    {
        public class Animal
        {
            public string color = "White";
        }
        public class Dog : Animal
        {
            string color = "Black";
            public void showColor()
            {
                Console.WriteLine(base.color);
                Console.WriteLine(color);
            }

        }
        public class TestBase
        {
            public static void Main()
            {
                Dog d = new Dog();
                d.showColor();
            }
        }
    }
}
