namespace GeometrySystem._2D
{
    /// <summary>
    /// 几何形状
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// 获得面积
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();

        /// <summary>
        /// 获得周长
        /// </summary>
        /// <returns></returns>
        public abstract double GetPerimeter();

        /// <summary>
        /// 重叠检测，检测两个多边形是否重叠
        /// </summary>
        /// <param name="other">其他形状</param>
        /// <returns>重叠就返回true，不重叠就返回false</returns>
        public abstract bool OverLaps(Shape other);
    }
}
