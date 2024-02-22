namespace Feature_Demo.Features
{
    public record Records(int X, int Y);

    public class RecordDemo : IDemonstrable
    {
        public void Demo(TextWriter outStream)
        {
            var r = new Records(420, 69);
            var x = r.X;
        }
    }
}