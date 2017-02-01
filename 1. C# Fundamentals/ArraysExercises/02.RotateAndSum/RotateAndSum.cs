using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ');
            int[] parsedNumber = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                parsedNumber[i] = int.Parse(inputArray[i]);
            }

            int n = int.Parse(Console.ReadLine());

            int[] sumArray = new int[inputArray.Length];

            for (int i = 0; i < n; i++)
            {
                int lastNumber = parsedNumber[parsedNumber.Length - 1];
                for (int j = parsedNumber.Length - 1; j > 0; j--)
                {
                    parsedNumber[j] = parsedNumber[j - 1];
                }
                parsedNumber[0] = lastNumber;

                for (int j = 0; j < parsedNumber.Length; j++)
                {
                    sumArray[j] += parsedNumber[j];
                }
            }
            Console.WriteLine(string.Join(" ",sumArray));
        }
    }
}
