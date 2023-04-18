using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Circle : Shape
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double calculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double calculatePerimeter()
        {
            return Math.PI * 2 * Radius;
        }
    }
}