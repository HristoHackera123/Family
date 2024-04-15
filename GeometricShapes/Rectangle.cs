using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Rectangle
    {
        public double a, b, perimeter, area;

        public void InputData()
        {
            Console.Write("a=");
            this.a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            this.b = double.Parse(Console.ReadLine());
        }
        public double FindPerimeter()
        {
            this.perimeter = (this.a + this.b) * 2;
            return this.perimeter;
        }
        public double FindArea()
        {
            this.area = this.a * this.b;
            return this.area;
        }
    }
}
