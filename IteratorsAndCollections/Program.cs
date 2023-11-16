namespace IteratorsAndCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            MyCollectionOfNumbers collection = new MyCollectionOfNumbers(1, 2, 3, 4);
            foreach (int i in collection)
            {
                Console.WriteLine(i);
            }
            

            Address address = new Address
            {
                Country = "Romania",
                City = "Bucharest",
                StreetName = "Bv. Magheru",
                StreetNumber = "16",
                BlockNumber = "XYZ",
                ApNumber = "23"
            };

            Console.WriteLine("Preparing to iterate address");
            foreach (string part in address)
            {
                Console.WriteLine("Obtained address part");
                Console.WriteLine(part);
            }
            */

            /*
            Console.WriteLine("Getting collection");
            IEnumerable<ulong> fibo = Fibonacci.Get(3);
            Console.WriteLine("Preparing to iterate collection");
            int step = 0;
            foreach (ulong elem in fibo)
            {
                Console.WriteLine($"Obtained F({step})={elem}");
                step++;
            }
            */

            int steps = 10, start = 0;
            // IEnumerable<int> collection = InfiniteNumbersGenerator.Generate();
            IEnumerable<int> collection = new EvenNumbersGenerator(InfiniteNumbersGenerator.Generate());
            foreach (int element in collection)
            {
                Console.WriteLine(element);
                start++;
                if (start >= steps)
                {
                    break;
                }
            }

            /*
             * IEnumerator enumeratorOfFibo = fibo.GetEnumerator();
             * while(enumeratorOfFibo.GetNext())
             * {
             *   // do something with enumeratorOfFibo.Current
             * }
             */
        }
    }
}