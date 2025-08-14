using System.Threading.Channels;

namespace Calc
{
    class Calculation
    {
        public static double pi = 3.14;
        public double Area(double radius) //Area of circle
        {
            return pi * radius * radius;
        }
        public int Area(int side) //Area of square
        {
            return side * side;
        }
        public double Area(double length, double width) //Area of rectangle
        {
            return length * width;
        }
        public double Area(float length, float height) //Area of triangle
        {
            return 0.5 * length * height;
        }


        public double Perimeter(double radius) //Perimeter of circle
        {
            return 2 * pi * radius;
        }
        public int Perimeter(int side) //Perimeter of square
        {
            return 4 * side;
        }
        public double Perimeter(double length, double width) //Perimeter of rectangle
        {
            return 2 * (length + width);
        }

        public double Perimeter(float side1, float side2, float side3) //Perimeter of triangle
        {
            return side1 + side2 + side3;
        }

    }
    class MethodOverloading
    {
        public static void Main(string[] args)
        {
            Calculation c = new Calculation();

            Console.WriteLine("---------------- Area ----------------");

            Console.WriteLine("Area of circle : " + c.Area(5.5));
            Console.WriteLine("Area of square : " + c.Area(5));
            Console.WriteLine("Area of rectangle : " + c.Area(2.5, 3.5));
            Console.WriteLine("Area of triangle : " + c.Area(3.5f, 2.1f));

            Console.WriteLine("---------------- Perimeter ----------------");

            Console.WriteLine("Perimeter of circle : " + c.Perimeter(5.5));
            Console.WriteLine("Perimeter of square : " + c.Perimeter(5));
            Console.WriteLine("Perimeter of rectangle : " + c.Perimeter(2.5, 3.5));
            Console.WriteLine("Perimeter of triangle : " + c.Perimeter(2.5f, 2.5f, 3.5f));
        }
    }
}