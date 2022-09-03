using MyMathLib.Shapes.Abstarct;

namespace MyMathLib.Shapes
{
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        private Triangle(double a, double b, double c)
        {
            _sideA = a;
            _sideB = b;
            _sideC = c;
        }

        public double GetArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        public bool TriangleExist() =>
            _sideA < _sideB + _sideC
            && _sideB < _sideA + _sideC
            && _sideC < _sideA + _sideB;

        public bool IsRightTriangle() =>
           Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideC, 2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Катет</param>
        /// <param name="b">Катет</param>
        /// <param name="c">Гипотенуза</param>
        /// <returns></returns>
        public static Triangle Create(double a, double b, double c) =>
            new(a, b, c);

    }
}
