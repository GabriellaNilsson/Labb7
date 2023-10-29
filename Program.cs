namespace Labb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating object reference
            var circle = new Circle();
            double circleArea = circle.Area();
            Console.WriteLine("The area of the circle: " + circleArea.ToString("N2"));

            var rectangle = new Rectangle();
            double rectangleArea = rectangle.Area();
            Console.WriteLine("The area of a rectangle: " + rectangleArea);

            var square = new Square();
            double sqaureArea = square.Area();
            Console.WriteLine("The area of a square: " + sqaureArea);

            var parallelogram = new Parallelogram();
            double parallelogramArea = parallelogram.Area();
            Console.WriteLine("The area of a parallelogram: " + parallelogramArea);

            var ellipse = new Ellipse();
            double ellipseArea = ellipse.Area();
            Console.WriteLine("The area of an ellipse: " + ellipseArea.ToString("N2"));
        }
    }
}