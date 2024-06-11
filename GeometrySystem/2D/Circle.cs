using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetPerimeter()
        {
            return Math.PI * 2 * Radius;
        }
    }
}
