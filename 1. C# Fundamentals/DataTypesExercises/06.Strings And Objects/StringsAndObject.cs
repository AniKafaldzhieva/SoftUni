using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringsAndObject
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";
            object concatenation = word1 + " " + word2;
            //string word3 = word1.Cast<word2>;
            Console.WriteLine(concatenation);
        }
    }
}
