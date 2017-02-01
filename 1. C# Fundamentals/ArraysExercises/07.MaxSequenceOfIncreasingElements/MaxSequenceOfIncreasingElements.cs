using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = 0;
            int maxStart = 0;
            int count = 0;
            int maxCount = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] - array[i - 1] >= 1)
                {
                    count++;
                    start = i - count;

                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxStart = start;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int j = maxStart; j <= (maxStart + maxCount); j++)
            {
                Console.Write(array[j] + " ");
            }
            Console.WriteLine();
        }
    }
}

