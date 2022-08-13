using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Calculate_Using_Method
{
    public class Calculate
    {
       public int num1;
       public int num2;

        public void addition(int a,int b)
        {
            int num1 = a;
            int num2 = b;
            int res = num1 + num2;
            Console.WriteLine("Addition  "+ res);
        }
        public void subtraction(int a,int b)
        {
            int num1 = a;
            int num2 = b;
            int res = num1 - num2;
            Console.WriteLine("Subtraction  " + res);
        }
        public void multiplication(int a, int b)
        {
            int num1 = a;
            int num2 = b;
            int res = num1 * num2;
            Console.WriteLine("Addition  " + res);
        }
        public void division(int a,int b)
        {
            int num1 = a;
            int num2 = b;
            int res = num1 / num2;
            Console.WriteLine("Addition  " + res);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            Console.WriteLine("Enter 1st Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            calc.addition(num1,num2);
            calc.subtraction(num1,num2);
            calc.multiplication(num1,num2);
            calc.division(num1,num2);
           
        }
    }
}
