using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split(' ');

            int sum = 0;

            for (int i = 0; i < inputList.Length; i++)
            {
                var numbers = inputList[i];
                var reversedNumbers = numbers.Reverse().ToList();
                var resultNumbers = string.Join("", reversedNumbers);
                var parsedNumbers = int.Parse(resultNumbers);
                sum += parsedNumbers;
            }
            Console.WriteLine(sum);
        }
        // Console.WriteLine(Console.ReadLine().Split().Select(x=>int.Parse(string.Join("", x.Reverse()))).Sum());
    }
}
