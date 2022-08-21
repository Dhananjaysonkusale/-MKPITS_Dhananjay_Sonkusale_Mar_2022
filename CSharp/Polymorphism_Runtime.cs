using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Runtime
{
    internal class Program
    {
        public class Person
        {
            public virtual void dance()
            {
                Console.WriteLine("Dancing");
            }
        }
        public class Boys : Person
        {
            public override void dance()
            {
                Console.WriteLine("Boys Are Dancing");
            }
        }
        static void Main(string[] args)
        {
            Person p = new Boys();
            p.dance();
            
        }
    }
}
