namespace GeometryLib
{
    public static class ShapeFactory
    {
        public static IShape CreateShape(string shapeType, params double[] parameters)
        {
            return shapeType.ToLower() switch
            {
                "circle" when parameters.Length == 1 => new Circle(parameters[0]),
                "rectangle" when parameters.Length == 2 => new Rectangle(parameters[0], parameters[1]),
                "triangle" when parameters.Length == 3 => new Triangle(parameters[0], parameters[1], parameters[2]),
                _ => throw new ArgumentException("Недопустимый тип фигуры или параметры.")
            };
        }
    }
}
