using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {

            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');

            char[] arr1 = new char[array1.Length];
            char[] arr2 = new char[array2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = char.Parse(array1[i]);
            }
            for (int j = 0; j < arr2.Length; j++)
            {
                arr2[j] = char.Parse(array2[j]);
            }

            if (arr1.Length > arr2.Length)
            {
                Console.WriteLine($"{string.Join("", arr2)}\n{string.Join("", arr1)}");
            }
            else if (arr1.Length < arr2.Length)
            {
                Console.WriteLine($"{string.Join("", arr1)}\n{string.Join("", arr2)}");
            }
            else if (arr1.Length == arr2.Length)
            {

                for (int k = 0; k < Math.Min(arr1.Length, arr2.Length); k++)
                {

                    if (arr1[k] > arr2[k])
                    {
                        Console.WriteLine($"{string.Join("", arr2)}\n{string.Join("", arr1)}");
                        break;
                    }
                    else if (arr1[k] < arr2[k])
                    {
                        Console.WriteLine($"{string.Join("", arr1)}\n{string.Join("", arr2)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{string.Join("", arr1)}\n{string.Join("", arr2)}");
                        break;
                    }
                }
            }
        }
    }
}
