using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> primes = FindPrimesInRange(startNum, endNum);

            for (int i = 0; i < primes.Count; i++)
            {
                Console.Write(primes[i]);
                if (i == primes.Count-1)
                {
                    Console.WriteLine();
                    break;
                }
                Console.Write(", ");
            }
        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();
            if (startNum < 2)
            {
                startNum = 2;
            }
            for (var i = startNum; i <= endNum; i++)
            {
                var isPrime = true;
                var n = Math.Floor(Math.Sqrt(i));

                for (var j = 2; j <= n; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
    }
}
