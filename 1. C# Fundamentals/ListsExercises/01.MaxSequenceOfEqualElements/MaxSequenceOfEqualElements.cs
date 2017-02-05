using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int count = 0;
            int maxCount = 0;
            int start = 0;

            for (int i = 0; i < inputList.Count-1; i++)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    count++;
                    if (count>maxCount)
                    {
                        start = i - count;
                        maxCount = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            for (int i = start+1; i <= start+maxCount+1; i++)
            {
                Console.Write(inputList[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
