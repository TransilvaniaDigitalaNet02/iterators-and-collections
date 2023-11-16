using System.Collections;

namespace IteratorsAndCollections
{
    internal class MyCollectionOfNumbers : IEnumerable<int>
    {
        private readonly List<int> _numbers;

        public MyCollectionOfNumbers(params int[] numbers)
        {
            _numbers = new List<int>(numbers);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        private IEnumerator<int> GetEnumeratorInternal()
        {
            return _numbers.GetEnumerator();
        }
    }
}
