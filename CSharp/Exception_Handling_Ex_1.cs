using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int n = 0;
            int res = num / n; //error will come here and program terminates
            Console.WriteLine("res= " +res);
            Console.WriteLine("bye");
        }
    }
}
