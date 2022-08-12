using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_No_Using_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int j, i;

			Console.WriteLine("Prime No Bet 1 to 20 :");
			

			for(j=1;j<=20;j++)
			{
				int d = 0;
				for (i = 2; i <= j / 2; i++)
				{
					if (j % i == 0)
					{
						d++;
						break;
					}
				}
				if(d==0 && j!=1)
                    {
						Console.WriteLine( j );
                    }
				
			}
			
			Console.ReadLine();
			}
		}
    }
