using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":
                    Console.WriteLine($"{faceCube(side):f2}");
                    break;
                case "space":
                    Console.WriteLine($"{spaceCube(side):f2}");
                    break;
                case "volume":
                    Console.WriteLine($"{volumeCube(side):f2}");
                    break;
                case "area":
                    Console.WriteLine($"{areaCube(side):f2}");
                    break;
            }
        }
        static double faceCube(double side)
        {
            side = Math.Sqrt(2) * side;
            return side; 
        }
        static double spaceCube(double side)
        {
            side = Math.Sqrt(3) * side;
            return side;
        }
        static double volumeCube(double side)
        {
            side = Math.Pow(side, 3);
            return side;
        }
        static double areaCube(double side)
        {
            side = 6 * side * side;
            return side;
        }
    }
}
