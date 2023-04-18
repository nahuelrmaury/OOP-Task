using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Square : Shape
    {
        public Square(double Length)
        {
            this.Length = Length;
        }
        public override double calculateArea()
        {
            return Math.Pow(Length, 2);
        }
        public override double calculatePerimeter()
        {
            return Length * 4;
        }
    }
}