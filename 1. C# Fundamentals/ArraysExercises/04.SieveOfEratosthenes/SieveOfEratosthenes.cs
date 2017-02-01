using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] notPrime = new bool[n+1];

            for (int i = 0; i <= n; i++)
            {
                notPrime[i] = true;
            }

            notPrime[0] = false;
            notPrime[1] = false;

            for (int j = 2; j <= n; j++)
            {
                if (notPrime[j])
                {
                    for (int k = 2; k*j <= n; k++)
                    {
                        notPrime[k * j] = false;
                    }
                }
            }
            for (int l = 2; l <= n; l++)
            {
                if (notPrime[l])
                {
                    Console.Write(string.Join(" " , l) + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
