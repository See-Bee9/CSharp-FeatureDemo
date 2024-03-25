namespace Feature_Demo.Features
{
    public class ObjectDeconstruction(int _x, int _y, int _z) 
    {

        public void Deconstruct(out int x, out int y, out int z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        
        public void Demo(TextWriter outStream)
        {
            var (a, b, c) = (this);
            
            outStream.WriteLine($"{a}, {b}, {c}");
        }
    }
}