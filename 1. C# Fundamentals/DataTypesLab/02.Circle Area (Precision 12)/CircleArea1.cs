using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class CircleArea1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Circle area is: {0:f12}", Math.PI * r * r);
        }
    }
}
