using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySystem._2D
{
    /// <summary>
    /// 2维坐标系中的线段
    /// </summary>
    public class SegmentLine2D
    {
        /// <summary>
        /// 线段的端点1
        /// </summary>
        public Point2D point1;

        /// <summary>
        /// 线段的端点2
        /// </summary>
        public Point2D point2;

        /// <summary>
        /// 使用两个2维坐标系中的点来初始化线段
        /// </summary>
        /// <param name="point1">点1</param>
        /// <param name="point2">点2</param>
        public SegmentLine2D(Point2D point1, Point2D point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        /// <summary>
        /// 获得线段的斜率
        /// </summary>
        /// <exception cref="Exception">当两个点的X坐标相等的时候，斜率无穷大，会抛出异常</exception>
        /// <returns>返回线段的斜率</returns>
        public double GetK()
        {
            if(point1.X == point2.X)
            {
                new Exception("斜率无穷大");
            }
            double k = (point1.Y-point2.Y)/(point1.X-point2.X);
            return k;
        }

        /// <summary>
        /// 获得线段的长度
        /// </summary>
        /// <returns>线段的长度</returns>
        public double GetDistance()
        {
            double xGap = Math.Pow(point1.X - point2.X, 2),
                yGap = Math.Pow(point1.Y - point2.Y, 2),
                distance = Math.Sqrt(xGap + yGap);
            return distance;
        }
    }
}
