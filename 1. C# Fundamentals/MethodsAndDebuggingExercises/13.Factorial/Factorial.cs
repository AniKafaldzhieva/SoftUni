using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Fact(number));
        }
        static BigInteger Fact(BigInteger number)
        {
            if (number==1)
            {
                return 1;
            }
            return number * Fact(number - 1);
        }
    }
}
