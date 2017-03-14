using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FlexibleArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[] { 1, 4, 6, 7, 9 };
            int[] arrayTwo = new int[] { 2, 3, 5, 6 };
            int[] arrayThree = new int[] { 4, 5, 7 };

            int sum = 0;
            int add = 0;
            int plus = 0;
            int x;
            int y;
            int z;

            for( x = 0; x < arrayOne.Length; ++x)
            {
                Write("{0, 2}", arrayOne[x]);
                sum += arrayOne[x]; 
            }
            WriteLine(":  Sum of first array", x + 1);
            WriteLine(sum);


            WriteLine("\n------------------");
            for (y = 0; y < arrayTwo.Length; ++y)
            {
                Write("{0, 2}", arrayTwo[y]);
                add += arrayTwo[y];
            }
            WriteLine(":  Sum of second array", y + 1);
            WriteLine(add);


            WriteLine("\n------------------");
            for (z = 0; z < arrayThree.Length; ++z)
            {
                Write("{0, 2}", arrayThree[z]);
                plus += arrayThree[z];
            }
            WriteLine(":  Sum of third array", z + 1);
            WriteLine(plus);


            ReadKey();

        }
    }
}
