using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Entities
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Сторона треугольника - A
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// Сторона треугольника - B
        /// </summary>
        public double B { get; set; }
        /// <summary>
        /// Сторона треугольника - C
        /// </summary>
        public double C { get; set; }

        public Triangle() { }

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="a">
        /// Сторона треугольника - A
        /// </param>
        /// <param name="b"> 
        /// Сторона треугольника - B
        /// </param>
        /// <param name="c"> 
        /// Сторона треугольника - C
        /// </param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            Perimeter = a + b + c;
            // полупериметр
            double p = Perimeter / 2;
            Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
