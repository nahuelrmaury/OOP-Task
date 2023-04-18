using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public abstract class Shape
    {
        public double Radius;
        public double Length;
        public double Base;
        public double Height;
        public abstract double calculateArea();
        public abstract double calculatePerimeter();
    }
}