namespace Feature_Demo.Features
{
    public class SpanT : IDemonstrable
    {
        private string path = @"./dates.txt";


        private static DateTime GetPurchaseDateWithSpan(string fileString, int start)
        {
            var dateSpan = fileString.AsSpan().Slice(start, 8);

            var yearSpan = dateSpan.Slice(0, 4);
            var monthSpan = dateSpan.Slice(4, 2);
            var daySpan = dateSpan.Slice(6, 2);

            return new DateTime(int.Parse(yearSpan), int.Parse(monthSpan), int.Parse(daySpan));
        }

        private static IEnumerable<DateTime> MapPurchaseDateWithSpan(string dateString)
        {
            for (var i = 0; i < dateString.Length; i += 8)
            {
                yield return GetPurchaseDateWithSpan(dateString, i);
            }
        }

        private static IEnumerable<DateTime> MapPurchaseDate(string fileString)
        {
            for (var i = 0; i < fileString.Length; i += 8)
            {
                var yearSpan = fileString.Substring(i, 4);
                var monthSpan = fileString.Substring(i + 4, 2);
                var daySpan = fileString.Substring(i + 6, 2);

                var (year, month, day) = (int.Parse(yearSpan), int.Parse(monthSpan), int.Parse(daySpan));
                yield return new DateTime(year, month, day);
            }
        }

        public void Demo(TextWriter outStream)
        {
            var file = File.ReadAllText(path);
            
            // To demo, show DemoSpan and DemoString separately in Memory Profiler. 

            // DemoSpan(file);

            DemoString(file);
        }

        private void DemoString(string file)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var dates = MapPurchaseDate(file);
            foreach (var date in dates)
            {
                // Simulate doing work
                var newDate = date.AddDays(1);
            }

            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        private void DemoSpan(string file)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var dates = MapPurchaseDateWithSpan(file);
            foreach (var date in dates)
            {
                // Simulate doing work
                var newDate = date.AddDays(1);
            }

            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}