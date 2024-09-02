using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом.", nameof(radius));

            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
