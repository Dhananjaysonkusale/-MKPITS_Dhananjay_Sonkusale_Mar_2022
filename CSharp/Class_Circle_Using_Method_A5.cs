using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Circle_Using_Method_A5
{
    class Circle
    {
        public float radius;

        public void area(float r)
        {
            float area = 3.13f * r * r;
            Console.WriteLine("Area = "+area);
        }
        public void circ(float r)
        {
            float circum = 2 * 3.14f * r;
            Console.WriteLine("Circumference = " + circum);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            Console.WriteLine("Enter Radius : ");
            float radius =Convert.ToSingle(Console.ReadLine());

            cir.area(radius);
            cir.circ(radius);
        }
    }
}
