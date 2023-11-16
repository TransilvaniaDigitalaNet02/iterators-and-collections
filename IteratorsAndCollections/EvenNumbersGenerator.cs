using System.Collections;

namespace IteratorsAndCollections
{
    internal class EvenNumbersGenerator : IEnumerable<int>
    {
        private readonly IEnumerable<int> _source;

        public EvenNumbersGenerator(IEnumerable<int> source)
        {
            _source = source;
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
            foreach (int element in _source)
            {
                bool isEven = element % 2 == 0;
                if (isEven)
                {
                    yield return element;
                }
            }
        }
    }
}
