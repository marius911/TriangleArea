using System;

namespace TriangleArea
{
    public struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public struct Triangle
    {
        public Point A;
        public Point B;
        public Point C;

        public Triangle(Point a, Point b, Point c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
    }

    public class Program
    {
        public static double CalculateArea(Triangle triangle)
        {
            // TO DO: remove the line below and implement this function
            double distanceAToB = GetDistanceBetweenPoint(triangle.A, triangle.B);
            double distanceAToC = GetDistanceBetweenPoint(triangle.A, triangle.C);
            double distanceBToC = GetDistanceBetweenPoint(triangle.B, triangle.C);
            double semiPerimeter = GetSemiPerimeter(distanceAToB, distanceAToC, distanceBToC);
            return Math.Sqrt(semiPerimeter
                * (semiPerimeter - distanceAToB)
                * (semiPerimeter - distanceAToC)
                * (semiPerimeter - distanceBToC));
        }

        public static double GetSemiPerimeter(double distanceAToB, double distanceAToC, double distanceBToC)
        {
            const double half = 2;
            return (distanceAToB + distanceAToC + distanceBToC) / half;
        }

        public static double GetDistanceBetweenPoint(Point a, Point b)
        {
            const double squared = 2;
            return Math.Sqrt(
                Math.Pow(a.X - b.X, squared)
                + Math.Pow(a.Y - b.Y, squared));
        }

        static Point ReadPoint()
        {
            string[] point = Console.ReadLine().Split(' ');
            return new Point(Convert.ToDouble(point[0]), Convert.ToDouble(point[1]));
        }

        static void Main()
        {
            double area = CalculateArea(new Triangle(ReadPoint(), ReadPoint(), ReadPoint()));
            Console.WriteLine(area.ToString("0.#"));
            Console.Read();
        }
    }
}
