using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndCollections
{
    internal static class Fibonacci
    {
        public static IEnumerable<ulong> Get(int n)
        {
            Console.WriteLine("Calculate F0");
            yield return 0;
            Console.WriteLine("After calculate F0");

            if (n >= 1)
            {
                Console.WriteLine("Calculate F1");
                yield return 1;
                Console.WriteLine("After calculate F1");
            }

            Console.WriteLine("Preparing to calculate next elements (greater than F1)");
            ulong lastN1 = 0;
            ulong lastN2 = 1;
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine($"Calculate F{i}");
                ulong currentN = lastN1 + lastN2;
                yield return currentN;
                Console.WriteLine($"After calculate F{i}");

                Console.WriteLine("Adjusting F(N-1) and F(N-2)");
                lastN2 = lastN1;
                lastN1 = currentN;
            }
        }
    }
}
