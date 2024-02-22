namespace Feature_Demo.Features
{
    public class Yield : IDemonstrable
    {
        private IEnumerable<int> WithYield(int count, Predicate<int> exitWhen)
        {
            for (var i = 0; i < count; i++)
            {
                if(exitWhen(i)) yield break;
                yield return i;
            }
        }

        private IEnumerable<int> WithList(int count, Predicate<int> exitWhen)
        {
            List<int> values = new(count);

            for (var i = 0; i < count; i++)
            {
                if (exitWhen(i)) return values;
                values.Add(i);
            }

            return values;
        }

        // To demo, use each method with the memory profiler
        public void Demo(TextWriter outStream)
        {
            var results = WithList(100000007, i => false);

            foreach (var r in results)
            {
                // Simulate doing work
                if (r * 1 == -1) Console.WriteLine(r);
            }
        }
    }
}