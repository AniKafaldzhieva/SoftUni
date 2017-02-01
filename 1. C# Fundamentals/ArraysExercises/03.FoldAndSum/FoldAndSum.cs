using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ');
            int[] parsedNumbers = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                parsedNumbers[i] = int.Parse(inputArray[i]);
            }

            int[] leftSide = new int[parsedNumbers.Length / 4];
            int[] rightSide = new int[parsedNumbers.Length / 4];
            int[] sum = new int[parsedNumbers.Length / 2];

            for (int i = 0; i < (parsedNumbers.Length/4); i++)
            {
                leftSide[i] = parsedNumbers[(parsedNumbers.Length / 4) - i - 1];
                rightSide[i] = parsedNumbers[(parsedNumbers.Length - 1 - i)];
            }

            for (int i = 0; i < parsedNumbers.Length/4; i++)
            {

                sum[i] = leftSide[i] + parsedNumbers[parsedNumbers.Length / 4 + i];
                sum[parsedNumbers.Length / 4 + i] = rightSide[i] + parsedNumbers[parsedNumbers.Length / 2 + i];
                
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
