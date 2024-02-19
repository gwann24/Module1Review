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

                int? shape;
                Console.WriteLine("Select the number of the shape you want to calculate the area for?");
                Console.WriteLine(" 1 - Circle");
                Console.WriteLine(" 2 - Triangle");
                Console.WriteLine(" 3 - Rectangle");
                Console.WriteLine(" 4 - Square");
                Console.WriteLine("\nSelection:");
                shape = Int32.Parse(Console.ReadLine());

                Console.WriteLine(shape);
        }
    }
}
