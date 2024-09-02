using GeometryLib;

namespace GeometryArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = ShapeFactory.CreateShape("circle", 5);
            Console.WriteLine($"Площадь круга: {shape1.CalculateArea()}");

            IShape shape2 = ShapeFactory.CreateShape("triangle", 3, 4, 5);
            Console.WriteLine($"Площадь треугольника: {shape2.CalculateArea()}");

            bool isRight = ((Triangle)shape2).IsRightTriangle();
            Console.WriteLine($"Треугольник прямоугольный? {isRight}");

            IShape shape3 = ShapeFactory.CreateShape("rectangle", 3, 4);
            Console.WriteLine($"Площадь прямоугольника: {shape3.CalculateArea()}");
        }
    }
}
