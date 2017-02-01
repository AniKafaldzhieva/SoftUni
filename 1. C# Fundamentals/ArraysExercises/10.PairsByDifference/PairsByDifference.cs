using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int count = 0;
            int numbers = 0;

            for (int j = 0; j < inputArray.Length; j++)
            {
                for (int i = j; i < inputArray.Length; i++)
                {
                    numbers = Math.Abs(inputArray[j] - inputArray[i]);
                    if (numbers == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
