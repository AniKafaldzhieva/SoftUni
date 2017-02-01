using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            var charArray = Console.ReadLine().ToLower().ToCharArray();
           
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine($"{charArray[i]} -> {charArray[i] % 32 - 1}");
            }
        }
    }
}
