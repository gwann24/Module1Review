using System.Reflection.Metadata;

namespace Module1Review
{
    public class Program
    {
        // Method to calculate area of a circle based on radius paramater.
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        // Method to calculate area of a triangle based on base length and height paramater.
        public static double AreaOfTriangle(double baselength, double height)
        {
            return (baselength * height)/2;
        }
        // Method to calculate area of a rectangle based on length and width paramater.
        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }
        // Method to calculate area of a square based on side paramater.
        public static double AreaOfSquare(double side)
        {
            return Math.Pow(side, 2);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            double radius;
            double baselength;
            double height;
            double length;
            double width;
            double side;

            Console.WriteLine("Select the number of the shape you want to calculate the area for?");
            Console.WriteLine(" 1 - Circle");
            Console.WriteLine(" 2 - Triangle");
            Console.WriteLine(" 3 - Rectangle");
            Console.WriteLine(" 4 - Square");
            Console.WriteLine("\nSelection:");
            Int32.TryParse(Console.ReadLine(), out int shape);

            switch (shape) {
                case 1:
                    Console.WriteLine("What is the radius of your circle?");
                    radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The area of a circle with radius {radius} is {AreaOfCircle(radius)}.");
                    break;
                case 2:
                    Console.WriteLine("What is the baselength of your triangle?");
                    baselength = double.Parse(Console.ReadLine());
                    Console.WriteLine("What is the height of your triangle?");
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The area of a triangle with baselength {baselength} and height {height} is {AreaOfTriangle(baselength,height)}.");
                    break;
                case 3:
                    Console.WriteLine("What is the length of your rectangle?");
                    length = double.Parse(Console.ReadLine());
                    Console.WriteLine("What is the width of your rectangle?");
                    width = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The area of a rectangle with length {length} and width {width} is {AreaOfRectangle(length, width)}.");
                    break;
                case 4:
                    Console.WriteLine("What is the side of your square?");
                    side = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The area of a square with side {side} is {AreaOfSquare(side)}.");
                    break;
                default:
                    Console.WriteLine("No Shape Selected!");
                    break;
            }
        }
    }
}
