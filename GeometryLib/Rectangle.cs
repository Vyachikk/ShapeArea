namespace GeometryLib
{
    public class Rectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Высота и ширин должны быть положительными числами.");

            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
