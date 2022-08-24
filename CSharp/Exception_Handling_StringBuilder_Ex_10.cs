using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_StringBuilder_Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Dhananjay ");
            sb.Append("Sonkusale");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("Bye");
        }
    }
}
