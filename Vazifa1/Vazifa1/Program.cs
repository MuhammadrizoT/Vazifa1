namespace Vazifa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine((Width + Height) * 2);
        }

        public void CalculateArea()
        {
            Console.WriteLine(Width * Height);
        }
        public void CalculateDiagonal()
        {
            Console.WriteLine(Math.Sqrt((Math.Pow(Width,2) + Math.Pow(Height, 2))));
        }
    }

    class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine( 2 * Math.PI * Radius);
        }
        public void CalculateArea()
        {
            Console.WriteLine( Math.PI * Math.Pow(Radius, 2));
        }
    }
}