using MyMathLib.Shapes.Abstarct;

namespace MyMathLib.Shapes
{
    public class Circle : IShape
    {
        private readonly double _radius;

        private Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea() =>
            Math.Pow(Math.PI * _radius, 2);

        public static Circle Create(double radius) =>
            new(radius);
    }
}
