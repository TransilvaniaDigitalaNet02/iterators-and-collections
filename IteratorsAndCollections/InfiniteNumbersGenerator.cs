namespace IteratorsAndCollections
{
    internal static class InfiniteNumbersGenerator
    {
        public static IEnumerable<int> Generate()
        {
            int start = 0;
            while(true)
            {
                yield return start;
                start++;
            }
        }
    }
}
