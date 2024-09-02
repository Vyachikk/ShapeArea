using GeometryLib;

namespace GeometryLibTests
{
    public class UnitTest
    {
        [Fact]
        public void CircleAreaTest()
        {
            var circle = new Circle(10);
            Assert.Equal(Math.PI * 100, circle.CalculateArea(), 1e-10);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea(), 1e-10);
        }

        [Fact]
        public void TriangleRightAngleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void InvalidTriangleTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
        }

        [Fact]
        public void InvalidCircleRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Fact]
        public void CreateCircle_ValidParameters_ReturnsCircle()
        {
            IShape shape = ShapeFactory.CreateShape("circle", 10);

            Assert.IsType<Circle>(shape);
            Assert.Equal(Math.PI * 100, shape.CalculateArea(), 1e-10);
        }

        [Fact]
        public void CreateTriangle_ValidParameters_ReturnsTriangle()
        {
            IShape shape = ShapeFactory.CreateShape("triangle", 3, 4, 5);

            Assert.IsType<Triangle>(shape);
            Assert.Equal(6, shape.CalculateArea(), 1e-10);
        }

        [Fact]
        public void CreateCircle_InvalidParameters_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => ShapeFactory.CreateShape("circle", -5));
            Assert.Contains("Радиус должен быть положительным числом.", ex.Message);
        }

        [Fact]
        public void CreateTriangle_InvalidParameters_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => ShapeFactory.CreateShape("triangle", 1, 2, 10));
            Assert.Contains("Треугольника с такими сторонами не существует.", ex.Message);
        }

        [Fact]
        public void CreateShape_InvalidParametersCount_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => ShapeFactory.CreateShape("triangle", 3, 4));
            Assert.Contains("Недопустимый тип фигуры или параметры.", ex.Message);
        }
    }
}