using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
