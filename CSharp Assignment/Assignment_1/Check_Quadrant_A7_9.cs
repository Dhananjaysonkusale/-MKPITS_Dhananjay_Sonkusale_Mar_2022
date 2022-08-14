using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Quadrant_A7_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter x Coordinate : ");
            x=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y Coordinate : ");
            y=Convert.ToInt32(Console.ReadLine());
            if(x>0 && y>0)
            {
                Console.WriteLine("Point ({0},{1}) lies in the First quadrant.", x, y);
            }
            else if(x<0 && y>0)
            {
                Console.WriteLine("Point ({0},{1}) lies in the Second quadrant.", x, y);
            }
            else if(x<0 && y<0)
            {
                Console.WriteLine("Point ({0},{1}) lies in the Third quadrant.", x, y);
            }
            else if(x>0 && y<0)
            {
                Console.WriteLine("Point ({0},{1}) lies in the Fourth quadrant.", x, y);
            }
        }
    }
}
