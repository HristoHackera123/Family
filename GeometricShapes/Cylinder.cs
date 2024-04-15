using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Cylinder
    {
        public double r, l, volume;

        public void InputData()
        {
            Console.Write("r=");
            this.r = double.Parse(Console.ReadLine());
            Console.Write("l=");
            this.l = double.Parse(Console.ReadLine());
        }
        public double FindVolume()
        {
            this.volume = Math.PI * this.r * this.r * this.l;
            return this.volume;
        }
    }
}
