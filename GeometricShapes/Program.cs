namespace GeometricShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.InputData();
            Console.WriteLine(triangle.FindPerimeter());
            Console.WriteLine(triangle.FindArea());

            
            Rectangle rectangle = new Rectangle();
            rectangle.InputData();
            Console.WriteLine(rectangle.FindPerimeter());
            Console.WriteLine(rectangle.FindArea());


            Trapezoid trapez = new Trapezoid();
            trapez.InputData();
            Console.WriteLine(trapez.FindPerimeter());
            Console.WriteLine(trapez.FindArea());

            Cylinder cylinder = new Cylinder();
            cylinder.InputData();
            Console.WriteLine(cylinder.FindVolume());
        }
    }
}
