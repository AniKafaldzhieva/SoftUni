using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FubonacciNumbers
{
    class FubonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibNumbers(n));
        }
        static int FibNumbers(int n)
        {
            int fib1 = 1;
            int fib2 = 1;
            
            for (int i = 0; i < n-1; i++)
            {
                int sum = fib1 + fib2;
                fib1 = fib2;
                fib2 = sum;
            }
            return (fib2);
        }
    }
}
