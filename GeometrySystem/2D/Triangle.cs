using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySystem._2D
{
    /// <summary>
    /// 三角形
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// 顶点1
        /// </summary>
        public Point2D Point1;

        /// <summary>
        /// 顶点2
        /// </summary>
        public Point2D Point2;

        /// <summary>
        /// 顶点3
        /// </summary>
        public Point2D Point3;

        /// <summary>
        /// 线段1
        /// </summary>
        public SegmentLine2D Line1;

        /// <summary>
        /// 线段2
        /// </summary>
        public SegmentLine2D Line2;

        /// <summary>
        /// 线段3
        /// </summary>
        public SegmentLine2D Line3;

        /// <summary>
        /// 使用3个顶点初始化三角形类
        /// </summary>
        /// <param name="point1">顶点1</param>
        /// <param name="point2">顶点2</param>
        /// <param name="point3">顶点3</param>
        public Triangle(Point2D point1, Point2D point2, Point2D point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Line1 = new SegmentLine2D(point1,point2);
            Line2 = new SegmentLine2D(point2,point3);  
            Line3 = new SegmentLine2D(point3,point1);
        }

        /// <summary>
        /// 获取三角形面积。
        /// 使用海伦公式计算
        /// </summary>
        /// <returns>使用海伦公式计算得出的三角形面积</returns>
        public override double GetArea()
        {
            double a = Point1.GetDistance(Point2),
                b = Point2.GetDistance(Point3),
                c = Point3.GetDistance(Point1),
                p = (a + b + c) / 2,
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        /// <inheritdoc cref="GetPerimeter"/>
        public override double GetPerimeter()
        {
            double distance1 = Line1.GetDistance(),
                distance2 = Line2.GetDistance(),
                distance3 = Line3.GetDistance();
            return distance1 + distance2 + distance3;
        }

        /// <inheritdoc cref="Shape.OverLaps(Shape)"/>
        public override bool OverLaps(Shape other)
        {
            throw new NotImplementedException();
        }
    }
}
