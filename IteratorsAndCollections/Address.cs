using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndCollections
{
    internal class Address : IEnumerable<string>
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string StreetName { get; set; }

        public string StreetNumber { get; set; }

        public string BlockNumber { get; set; }

        public string ApNumber { get; set; }

        public IEnumerator<string> GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumeratorInternal();
        }


        private IEnumerator<string> GetEnumeratorInternal()
        {
            Console.WriteLine($"About to yield return {nameof(Country)}");
            yield return Country;

            Console.WriteLine($"About to yield return {nameof(City)}");
            yield return City;

            Console.WriteLine($"About to yield return {nameof(StreetName)}");
            yield return StreetName;

            Console.WriteLine($"About to yield return {nameof(StreetNumber)}");
            yield return StreetNumber;

            Console.WriteLine($"About to yield return {nameof(BlockNumber)}");
            yield return BlockNumber;

            Console.WriteLine($"About to yield return {nameof(ApNumber)}");
            yield return ApNumber;
        }
    }
}
