using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');

            int count = 0;
            int countMax = 0;
            
            for (int i = 0; i <= Math.Min(array1.Length, array2.Length) - 1; i++)
            {

                if (array1[i] == array2[i])
                {
                    countMax++;
                }
                
            }
            Array.Reverse(array1);
            Array.Reverse(array2);

            for(int j =0; j <= Math.Min(array1.Length, array2.Length) - 1; j++ )
            {
                if (array1[j] == array2[j])
                {
                    count++;
                }
            }
            if (countMax >= count)
            {
                Console.WriteLine(countMax);
            }
            else
            {
                Console.WriteLine(count);
            }
        }
    }
}
