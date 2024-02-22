namespace Feature_Demo.Features
{
    public class Spread : IDemonstrable
    {
        private void Print(TextWriter writer, string prefix, int[] array)
        {
            var arrayString = String.Join(", ", array);

            writer.WriteLine($"{prefix} : {arrayString}");
        }

        public void Demo(TextWriter outStream)
        {
            int[] first = [1, 2, 3];
            int[] second = [4, 5, 6];
            int[] third = [7, 8, 9];

            int[] flat = [..first, ..second, ..third];
            Print(outStream, "Flattened", flat);

            var first5 = flat[5..];
            Print(outStream, "First five", first5);

            var last5 = flat[..5];
            Print(outStream, "Last five", last5);

            var middle = flat[3..5];
            Print(outStream, "Middle", middle);
        }
    }
}