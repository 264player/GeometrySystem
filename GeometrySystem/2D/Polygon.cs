using System.Text.RegularExpressions;

namespace GeometrySystem._2D
{
    /// <summary>
    /// 多边形
    /// </summary>
    public class Polygon : Shape
    {
        /// <summary>
        /// 多边形顶点集。
        /// 要求按照顺序排列
        /// </summary>
        public List<Point2D> Vertics;

        /// <summary>
        /// 多边形的线段集合
        /// </summary>
        public List<SegmentLine2D> Lines;

        /// <summary>
        /// 带有顶点集合参数的构造方法
        /// </summary>
        /// <param name="vertics">顶点集,顶点数量不能小于三个</param>
        public Polygon(List<Point2D> vertics)
        {
            Vertics = vertics;
            Lines = new List<SegmentLine2D>();
            IniLines(vertics);   
        }

        /// <summary>
        /// 使用顶点集填充线段集合
        /// </summary>
        /// <param name="vertics"></param>
        private void IniLines(List<Point2D> vertics)
        {
            for (int i = 0; i < Vertics.Count - 1; i++)
            {
                SegmentLine2D line = new SegmentLine2D(vertics[i], Vertics[i + 1]);
                Lines.Add(line);
            }
            Lines.Add(new SegmentLine2D(vertics[0], vertics[vertics.Count - 1]));
        }

       /// <summary>
       /// 使用耳切法进行三角剖分，获得面积。
       /// 适用于凸多边形
       /// </summary>
       /// <returns></returns>
        public override double GetArea()
        {
            double area = 0;
            Point2D origin = Vertics[0];
            for(int i = 1; i < Vertics.Count - 1; i++)
            {
                Triangle triangle = new Triangle(origin, Vertics[i], Vertics[i + 1]);
                area += triangle.GetArea();
            }
            return area;
        }

        /// <inheritdoc cref="Shape.GetPerimeter"/>
        public override double GetPerimeter()
        {
            double perimeter = 0;
            foreach(SegmentLine2D line in Lines)
            {
                perimeter += line.GetDistance();
            }
            return perimeter;
        }

        /// <inheritdoc cref="Shape.OverLaps(Shape)"/>
        public override bool OverLaps(Shape other)
        {
            throw new NotImplementedException();
        }
    }
}
