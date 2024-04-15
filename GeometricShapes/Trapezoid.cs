using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Trapezoid
    {
        public double a, b, c, d, h, perimeter, area;

        public void InputData()
        {
            Console.Write("a=");
            this.a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            this.b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            this.c = double.Parse(Console.ReadLine());
            Console.Write("d=");
            this.d = double.Parse(Console.ReadLine());
            Console.Write("h=");
            this.h = double.Parse(Console.ReadLine());
        }
        public double FindPerimeter()
        {
            this.perimeter = this.a + this.b + this.c + this.d;
            return this.perimeter;
        }
        public double FindArea()
        {
            this.area = (this.a + this.b) / 2 * this.h;
            return this.area;
        }
    }
}
