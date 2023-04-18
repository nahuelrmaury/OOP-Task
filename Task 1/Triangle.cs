using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Triangle : Shape
    {
        public Triangle(double Base, double Height)
        {
            this.Base = Base;
            this.Height = Height;
        }
        public override double calculateArea()
        {
            return Base * Height / 2;
        }
        public override double calculatePerimeter()
        {
            double Length = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Height, 2));
            return Base + Height + Length;
        }
    }
}