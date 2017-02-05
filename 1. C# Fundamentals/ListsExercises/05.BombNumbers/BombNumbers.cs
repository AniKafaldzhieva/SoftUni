using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] bombPower = Console.ReadLine().Split(); 

            int bombNumber = int.Parse(bombPower[0]);
            int powerNumber = int.Parse(bombPower[1]);
            

            for (int i = 0; i < inputList.Count-1; i++)
            {
                if (inputList[i] == bombNumber)
                {
                    int left = Math.Max(i - powerNumber, 0);
                    int right = Math.Min(i + powerNumber, inputList.Count - 1);

                    int lenght = right - left + 1;
                    inputList.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            //Console.WriteLine(string.Join(" ", inputList));
            Console.WriteLine(inputList.Sum());
        }
    }
}
