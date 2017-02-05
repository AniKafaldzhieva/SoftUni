using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] len = new int[input.Length];
            int[] prev = new int[input.Length];
            int maxLen = 0;
            int last = -1;

            for (int i = 0; i < input.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (input[j] < input[i] && len[j] >= len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }

                if (len[i] > maxLen)
                {
                    maxLen = len[i];
                    last = i;
                }
            }

            var sequence = new List<int>();

            for (int i = 0; i < maxLen; i++)
            {
                sequence.Add(input[last]);
                last = prev[last];
            }
            sequence.Reverse();
            sequence.ToArray();

            Console.WriteLine(string.Join(" ", sequence));
        } 
    }
}