﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName(name);
        }
        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
