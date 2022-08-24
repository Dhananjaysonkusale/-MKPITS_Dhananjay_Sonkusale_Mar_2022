using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Method_Ex_2
{
    internal class Program
    {
        public class Animal
        {
            public virtual void eat() { Console.WriteLine("eating..."); }

            public virtual void run() { Console.WriteLine("running..."); }

        }
        public class Dog : Animal
        {
            public override void eat() { Console.WriteLine("eating bread..."); }
            public sealed override void run()
            {
                Console.WriteLine("running very fast...");
            }
        }
        public class BabyDog : Dog
        {
            public override void eat() { Console.WriteLine("eating biscuits..."); }
            public override void run() { Console.WriteLine("running slowly..."); }
        }
        static void Main(string[] args)
        {
            BabyDog d = new BabyDog();
            d.eat();
            d.run();

            //Compile Time Error: 'BabyDog.run()':
            //cannot override inherited member 'Dog.run()' because it is sealed
        }
    }
}
