namespace Feature_Demo.Features
{
    public record Records(int X, int Y)
    {
    }

    public class RecordDemo
    {
        public void Demo()
        {
            var r = new Records(420, 69);
            var x = r.X;
        }
    }
}