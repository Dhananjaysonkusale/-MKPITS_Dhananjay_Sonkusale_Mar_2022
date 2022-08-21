using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Runtime_Ex_2
{
    internal class Program
    {
        class Science
        {
            public virtual void Sub()
            {
                Console.WriteLine("Science");
            }
        }
        class Physics : Science
        {
            public override void Sub()
            {
                Console.WriteLine("Physics");
            }
        }
        class Chemistry : Science
        {
            public override void Sub()
            {
                Console.WriteLine("Chemistry");
            }
        }
        class Biology : Science
        {
            public override void Sub()
            {
                Console.WriteLine("Chemistry");
            }
        }
        static void Main(string[] args)
        {
            Science s;
            s = new Science();
            s.Sub();
            s = new Physics();
            s.Sub();
            s = new Chemistry();
            s.Sub();
            s = new Biology();
            s.Sub();
        }
    }
}
