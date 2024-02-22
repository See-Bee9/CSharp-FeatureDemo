namespace Feature_Demo.Features
{
    public abstract class Shape
    {
    }

    public class Circle : Shape
    {
        public int Radius { get; init; }
    }

    public class Rectangle : Shape
    {
        public int Length { get; init; }

        public int Width { get; init; }
    }

    public class Square : Shape
    {
        public int Side { get; init; }
    }

    public class PatternMatching
    {
        public static void ProcessShapesWithoutPatterns(IEnumerable<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                if (shape is Circle)
                {
                    Circle c = (Circle)shape;
                    Console.WriteLine($"Circle with radius {c.Radius}: Area = {Math.PI * c.Radius * c.Radius}");
                }
                else if (shape is Rectangle)
                {
                    Rectangle r = (Rectangle)shape;
                    if (r.Length == r.Width)
                    {
                        // It's a square in terms of dimensions
                        Console.WriteLine($"Square (as rectangle) with side {r.Length}: Area = {r.Length * r.Length}");
                    }
                    else
                    {
                        Console.WriteLine($"Rectangle with length {r.Length} and width {r.Width}: Area = {r.Length * r.Width}");
                    }
                }
                else if (shape is Square)
                {
                    Square s = (Square)shape;
                    if (s.Side >= 0)
                    {
                        Console.WriteLine($"Square with side {s.Side}: Area = {s.Side * s.Side}");
                    }
                }
                else
                {
                    Console.WriteLine("Unknown shape");
                }
            }
        }

        public static void ProcessShapesWithPatterns(IEnumerable<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                switch (shape)
                {
                    case Circle c:
                        Console.WriteLine($"Circle with radius {c.Radius}: Area = {Math.PI * c.Radius * c.Radius}");
                        break;
                    case Rectangle {Length: var l, Width: var w} when l == w:
                        Console.WriteLine($"Square (as rectangle) with side {l}: Area = {l * l}");
                        break;
                    case Rectangle { Length: var l, Width: var w }:
                        Console.WriteLine($"Rectangle with length {l} and width {w}: Area = {l * w}");
                        break;
                    case Square {Side: >= 0} s:
                        Console.WriteLine($"Square with side {s.Side}: Area = {s.Side * s.Side}");
                        break;
                    default:
                        Console.WriteLine("Unknown shape");
                        break;
                }
            }
        }

    }
}