using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfTheASCIITable
{
    class PrintPartOfTheASCIITable
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (char i = Convert.ToChar(number); i <= Convert.ToChar(number2); i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
