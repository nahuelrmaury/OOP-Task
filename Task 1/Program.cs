using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Console.WriteLine($"Area of circle: {circle.calculateArea()}");
            Console.WriteLine($"Perimeter of circle: {circle.calculatePerimeter()}");
            Square square = new Square(8);
            Console.WriteLine($"Area of square: {square.calculateArea()}");
            Console.WriteLine($"Perimeter of square: {square.calculatePerimeter()}");
            Triangle triangle = new Triangle(11,12);
            Console.WriteLine($"Area of triangle: {triangle.calculateArea()}");
            Console.WriteLine($"Perimeter of triangle: {triangle.calculatePerimeter()}");
        }
    }
}