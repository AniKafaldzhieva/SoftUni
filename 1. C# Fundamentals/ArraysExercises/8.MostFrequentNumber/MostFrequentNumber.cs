using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int previous = array[0];
            int maxFrequent = 0;
            int count = 1;
            int maxCount = 0;

            for (int i = 1; i < array.Length; i++)
            {
                int currentNumber = array[i];
                if (currentNumber == previous)
                {
                    count++;
                    maxFrequent = array[i];
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
            }
            if (array.Length == 1)
            {
                maxCount = 0;
                maxFrequent = array[0];
            }
            Console.WriteLine($"{maxFrequent} - {maxCount}");
        }
    }
}
