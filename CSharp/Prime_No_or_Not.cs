using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_No_or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int n, i, d = 0;

			Console.WriteLine("Enter Any Number :");
			n = Convert.ToInt32(Console.ReadLine());

			i = 2;

			while (i < n)
			{
				if (n % i == 0)
				{
					d = 1;
					break;
				}
				i = i + 1;
			}
			if (d == 0)
			{
				Console.WriteLine("Enter Number is Prime !");
			}
			else
			{
				Console.WriteLine("Enter Number is Not Prime Number !");
			}
			Console.ReadLine();

		}
	}
}
