using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Class_Construction_Internally_2
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal");
        }
    }
    public class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog");
        }

    }
    public class TestOverriding
    {
        public static void Main()
        {
            Dog d = new Dog();

        }
    }
}
