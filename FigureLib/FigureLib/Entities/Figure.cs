using System;
using System.Collections.Generic;

namespace FigureLib.Entities
{
    /// <summary>
    /// Фигура
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Area { get; set; }
        /// <summary>
        /// Периметр фигуры
        /// </summary>
        public double Perimeter { get; set; }
    }
}
