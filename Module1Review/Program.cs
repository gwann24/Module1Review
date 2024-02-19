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
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
        }
    }
}
