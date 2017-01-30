using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            
            switch(figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{triangleArea(side, height):f2}");
                    break;
                case "square":
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{squareArea(a):f2}");
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double height2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{rectangleArea(width, height2):f2}");
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{circleArea(r):f2}");
                    break;

            }
        }
        static double triangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }
        static double squareArea(double a)
        {
            
            double area = a * a;
            return area;
        }
        static double rectangleArea(double width, double height2)
        {
           
            double area = width * height2;
            return area;
        }
        static double circleArea(double r)
        {
            double area = r * r * Math.PI;
            return area;
        }
    }
}
