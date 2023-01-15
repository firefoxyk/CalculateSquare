using CalculateSquare;

namespace CalculateSquareTests
{
    [TestClass]
    public class CalculateSquareTests
    {
        [TestMethod]
        public void CircleCalculateSquare()
        {
            double radius = 3;
            double expected = 28.274333882308138;

            Circle circle = new Circle(radius);
            double actual = circle.CalculateSquare();

            Assert.AreEqual(expected, actual, "Method is incorrect");
        }

        [TestMethod]
        public void TriangleCalculateSquare()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.CalculateSquare();

            Assert.AreEqual(expected, actual, "Method is incorrect");

        }
    }
}