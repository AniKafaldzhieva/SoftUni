﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorVolumeOfPyramid
{
    class Refactor
    {
        static void Main(string[] args)
        {
            Console.Write("Lenght: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            double heigth = double.Parse(Console.ReadLine());

            double volume = (lenght + width + heigth) / 3;

            Console.WriteLine("Pyramid Volume: {0:f2}", volume);
        }
    }
}
