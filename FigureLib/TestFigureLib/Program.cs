using FigureLib.Entities;
using System;

namespace TestFigureLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(3, 4, 5);
            ShowInfo(triangle);
            var circle = new Circle(2);
            ShowInfo(circle);
        }

        private static void ShowInfo(Triangle triangle)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Triangle");
            Console.WriteLine("A : " + triangle.A);
            Console.WriteLine("B : " + triangle.B);
            Console.WriteLine("C : " + triangle.C);
            ShowMoreInfo(triangle);
        }

        private static void ShowInfo(Circle circle)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Circle");
            Console.WriteLine("R : " + circle.R);
            ShowMoreInfo(circle);
        }

        private static void ShowMoreInfo(Figure figure)
        {
            Console.WriteLine("Perimeter : " + figure.Perimeter);
            Console.WriteLine("Area : " + figure.Area);
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
