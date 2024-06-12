using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometrySystem._2D;

namespace _2DGeometryTest.Shape
{
    public class PolygonTest
    {
        private Polygon _polygon;
        [SetUp]
        public void SetUp()
        {
            List<Point2D> points = new List<Point2D>()
            {
                new Point2D(0, 0),new Point2D(4, 0),new Point2D(6, 2),new Point2D(4, 4),new Point2D(0, 4)
            };

            _polygon = new Polygon(points);
        }

        [Test]
        public void NewPolygon()
        {
            Assert.NotNull(_polygon);
        }


        [Test]
        public void AreaTest()
        {
            double area = _polygon.GetArea();
            Assert.IsTrue((20.1 > area) && (19.9 < area),$"result:{area}"); //有误差
        }

        [Test]
        public void PerimeterTest()
        {
            double perimeter = 12 + Math.Sqrt(2) * 4;
            Assert.AreEqual(perimeter, _polygon.GetPerimeter());
        }
    }
}
