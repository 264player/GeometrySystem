using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometrySystem._2D;

namespace _2DGeometryTest.Shape
{
    public class CircleTest
    {
        private Circle _circle;
        [SetUp]
        public void SetUp()
        {
            Point2D center = new Point2D(0, 0);
            _circle = new Circle(10, center);
        }


        [Test]
        public void NewCircle()
        {
            Assert.NotNull(_circle);
        }

        [Test]
        public void AreaTest()
        {
            double area = Math.PI * Math.Pow(10, 2);
            Assert.AreEqual(area, _circle.GetArea());
        }


        [Test]
        public void PerimeterTest()
        {
            double perimeter = Math.PI * 2 * 10;
            Assert.AreEqual(perimeter, _circle.GetPerimeter());
        }


    }
}
