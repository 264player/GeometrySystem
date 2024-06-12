namespace GeometrySystem._2D
{
    /// <summary>
    /// 圆形
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// 半径
        /// </summary>
        public double Radius;

        /// <summary>
        /// 圆心
        /// </summary>
        public Point2D Center;

        /// <summary>
        /// 带有半径和中心点的构造方法
        /// </summary>
        /// <param name="radius">半径</param>
        /// <param name="center">原点</param>
        public Circle(double radius, Point2D center)
        {
            Radius = radius;
            Center = center;
        }

        /// <inheritdoc cref="Shape.GetArea"/>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <inheritdoc cref="Shape.GetPerimeter"/>
        public override double GetPerimeter()
        {
            return Math.PI * 2 * Radius;
        }

        /// <inheritdoc cref="Shape.OverLaps(Shape)"/>
        public override bool OverLaps(Shape other)
        {
            if (other is Circle circle)
            {
                return OverlapsForCircle(circle);
            }
            else if (other is Polygon polygon)
            {

            }
            return true;
        }

        /// <summary>
        /// 检测当前圆和目标圆是否重合
        /// </summary>
        /// <param name="other">目标圆形</param>
        /// <returns>重合就返回true，不重合就返回false</returns>
        public bool OverlapsForCircle(Circle other)
        {
            double distance = Center.GetDistance(other.Center);
            if(distance < ( other.Radius + this.Radius))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 检测当前圆和目标多边形是否重合
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool OverLapsForPolygon(Polygon other)
        {
            return true;
        }

    }
}
