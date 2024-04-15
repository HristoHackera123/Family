using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Triangle
    {
        public double a, b, c, ha, perimeter, area;

        public void InputData()
        {
            Console.Write("a=");
            this.a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            this.b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            this.c = double.Parse(Console.ReadLine());
            Console.Write("ha=");
            this.ha = double.Parse(Console.ReadLine());
        }
        public double FindPerimeter()
        {
            this.perimeter = this.a + this.b + this.c;
            return this.perimeter;
        }

        public double FindArea()
        {
            this.area = this.a * this.ha;
            return this.area;
        }
    }
}
