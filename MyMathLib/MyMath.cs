using MyMathLib.Shapes.Abstarct;

namespace MyMathLib
{
    public class MyMath
    {
        public static double FindShapeArea(IShape shape) =>
            shape.GetArea();
    }
}