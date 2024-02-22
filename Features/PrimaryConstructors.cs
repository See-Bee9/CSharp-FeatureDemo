namespace Feature_Demo.Features
{
    public class PrimaryConstructors(int x, int y)
    {
        public int GetMultipliedSum(int a, int b) => x * a + y * b;

        public void Mutate(int a, int b)
        {
            x = a;
            y = b;
        }
    }

    public class TraditionalConstructor
    {
        private readonly int _x;

        private readonly int _y;

        public TraditionalConstructor(int x, int y)
        {
            _x = x;
            _y = y;
        }
        
        public int GetMultipliedSum(int a, int b) => _x * a + _y * b;
    }
}