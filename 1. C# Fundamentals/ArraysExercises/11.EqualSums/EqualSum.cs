using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class EqualSum
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool found = false;

            if (inputArray.Length == 1)
            {
                Console.WriteLine("0");return;
            }
           
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += inputArray[j];
                }

                for (int l = i+1; l < inputArray.Length; l++)
                {
                    rightSum += inputArray[l];
                }

                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    found = true;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }
            if (found == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
