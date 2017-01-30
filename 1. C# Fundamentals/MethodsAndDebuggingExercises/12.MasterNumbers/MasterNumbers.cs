using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (IsPalindrome(i) && IsDivisiblebySeven(i) && evenDigit(i)==true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool IsPalindrome(int n)
        {
            bool palindrome = false;
            var firstDigit = n;
            var number = n;
            var reversed = 0;
            while (n > 0)
            {
                var digit = n % 10;
                reversed = reversed * 10 + digit;
                n = n / 10;
            }
            if (reversed == number)
            {
                palindrome = true;
            }
            return palindrome;
        }
        public static bool IsDivisiblebySeven(int n)
        {
            bool isDivisible = false;
            int sum = 0;
            while(n>0)
            {
                sum += n % 10;
                n /= 10;
            }
            if (sum % 7 == 0)
            {
                isDivisible = true;
            }
            return isDivisible;
        }
        public static bool evenDigit(int n)
        {
            bool isEven = false;
            int number = 0;
            while (n > 0)
            {
                number = n % 10;
                n /= 10;
                if (number % 2 == 0)
                {
                    isEven = true;
                }
            }
            return isEven;
        }
    }
}
