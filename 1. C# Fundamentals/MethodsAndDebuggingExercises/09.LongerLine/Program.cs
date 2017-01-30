using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double hypotenuse1 = Math.Sqrt(Math.Pow(Math.Abs(x1 - x2),2) + Math.Pow(Math.Abs(y1 - y2),2));
            double hypotenuse2 = Math.Sqrt(Math.Pow(Math.Abs(x3 - x4), 2) + Math.Pow(Math.Abs(y3 - y4), 2));

            if (hypotenuse1>=hypotenuse2)
            {
                double line1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
                double line2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
                if (line1>line2)
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else if(line1<=line2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
            else
            {
                double line3 = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
                double line4 = Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));
                if (line3 > line4)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else if(line3<=line4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
            }
        }
    }
}
