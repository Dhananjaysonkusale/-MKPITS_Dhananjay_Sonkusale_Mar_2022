using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sByte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte b1;
            Console.WriteLine("Enter bite ");
            b1 = Convert.ToSByte(Console.ReadLine());    // range of a Sbyte is -128 to 127
            Console.WriteLine("sbyte Entered = " + b1);

            Console.ReadLine();
        }
    }
}

/*C# type/keyword Range Size
short -32,768 to 32,767 Signed 16 - bit integer    -- Convert.ToInt16( Console.ReadLine());
ushort 0 to 65,535 Unsigned 16 - bit integer       -- Convert.ToUInt16( Console.ReadLine());
int -2,147,483,648 to 2,147,483,647 Signed 32 - bit integer
long -- Convert.ToInt64( Console.ReadLine());
uint 0 to 4,294,967,295 Unsigned 32 - bit integer
short datatype - consumes 2 bytes*/