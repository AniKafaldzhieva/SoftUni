using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger fact = 1;
            do
            {
                fact = fact * n;
                n--;
            } while (n > 1);
            Console.WriteLine(evenDigit(fact));
        }

        public static int evenDigit(BigInteger fact)
        {
            int count = 0;
            BigInteger number = 0;
            while (fact % 10 == 0)
            {
                fact /= 10;
                count++;
            }
            return count;
        }
    }
}
