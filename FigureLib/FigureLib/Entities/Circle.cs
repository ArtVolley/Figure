using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Entities
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double R { get; set; }

        public Circle() { }

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="r">
        /// Радиус круга - R
        /// </param>
        public Circle(double r)
        {
            R = r;
            Perimeter = 2 * Math.PI * r;
            Area = Math.PI * Math.Pow(r, 2);
        }
    }
}
