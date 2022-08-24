using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class_Ex_1
{
    internal class Program
    {
        sealed public class Animal
        {
            public void eat() { Console.WriteLine("eating..."); }
        }
        public class Dog : Animal
        {
            public void bark() 
            { 
                Console.WriteLine("barking..."); 
            }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();
            d.bark();
            //Compile Time Error: 'Dog': cannot derive from sealed type 'Animal'
        }
    }
}
