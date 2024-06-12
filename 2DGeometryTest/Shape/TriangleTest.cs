using GeometrySystem._2D;

namespace _2DGeometryTest.Shape
{
    [TestFixture]
    public class TriangleTest
    {
        Triangle t;
        [SetUp]
        public void SetUp()
        {
            Point2D p1 = new Point2D(0, 0),
                p2 = new Point2D(3, 0),
                p3 = new Point2D(0, 4);
            t = new Triangle(p1, p2, p3);

        }

        [Test]
        public void NewTriangle()
        {
            Assert.NotNull(t);
        }

        [Test]
        public void AreaTest()
        {
            Assert.AreEqual(6, t.GetArea());
        }

        [Test]
        public void PerimeterTest()
        {
            Assert.AreEqual(12, t.GetPerimeter());
        }
    }
}