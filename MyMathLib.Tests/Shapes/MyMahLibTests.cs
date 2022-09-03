using MyMathLib.Shapes;

namespace MyMathLib.Tests.Shapes
{
    [TestClass]
    public class MyMahLibTests
    {
        [TestMethod]
        public void FindCircleArea_20_3947dot841returned()
        {
            double radius = 20d;
            double expected = 3_947.8417604357434475337963999505d;

            double actual = MyMath.FindShapeArea(Circle.Create(radius));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindTriangleArea_20and20and20_173dot205returned()
        {
            double a = 20d,
                   b = 20d,
                   c = 20d;

            double expected = 173.20508075688772935274463415059d;

            double actual = MyMath.FindShapeArea(Triangle.Create(a, b, c));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TriangleExistTest()
        {
            double a = 20d,
                   b = 20d,
                   c = 20d;

            var triangle = Triangle.Create(a, b, c);

            bool expected = true;

            bool actual = triangle.TriangleExist();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsRightTriangleTest_false()
        {
            double a = 20d,
                   b = 20d,
                   c = 20d;

            var triangle = Triangle.Create(a, b, c);

            bool expected = false;

            bool actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsRightTriangleTest_true()
        {
            double a = 20d,
                   b = 21d,
                   c = 29d;

            var triangle = Triangle.Create(a, b, c);

            bool expected = true;

            bool actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual);
        }
    }
}