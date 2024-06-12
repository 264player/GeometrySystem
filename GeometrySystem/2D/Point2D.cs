namespace GeometrySystem._2D
{
    /// <summary>
    /// 表示2维坐标系中的一个点
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// 横坐标
        /// </summary>
        public double X;

        /// <summary>
        /// 纵坐标
        /// </summary>
        public double Y;

        /// <summary>
        /// 使用x和y左边初始化2维点类
        /// </summary>
        /// <param name="x">横坐标</param>
        /// <param name="y">纵坐标</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// 获得两点之间的距离
        /// </summary>
        /// <returns></returns>
        public double GetDistance(Point2D point)
        {
            double pdistance = Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2);
            double result = Math.Sqrt(pdistance);
            return result;
        }
    }
}
