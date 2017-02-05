using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ');

            while (command[0] != "print")
            {
                
                if (command[0] == "add")
                {
                    inputArray.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "addMany")
                {
                    for (int i = 0; i < command.Length-2; i++)
                    {
                        inputArray.Insert(int.Parse(command[1]) + i, int.Parse(command[2+i]));
                    }
                }
                if (command[0] == "contains")
                {
                    var number = int.Parse(command[1]);

                    if (inputArray.Contains(number))
                    {
                        for (int i = 0; i < inputArray.Count; i++)
                        {
                            if (number == inputArray[i])
                            {
                                Console.WriteLine(i);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                if (command[0] == "remove")
                {
                    inputArray.RemoveAt(int.Parse(command[1]));
                }
                if (command[0] == "shift")
                {
                    var number = int.Parse(command[1]);

                    for (int i = 0; i < number; i++)
                    {
                        var shiftNumbers = inputArray[0];
                        for (int j = 0; j < inputArray.Count-1; j++)
                        {
                            inputArray[j] = inputArray[j + 1];
                        }
                        inputArray[inputArray.Count - 1] = shiftNumbers;
                    }
                }
                if (command[0] == "sumPairs")
                {
                    var sum = new List<int>();
                    if (inputArray.Count % 2 == 0)
                    {
                        for (int i = 0; i < inputArray.Count; i++)
                        {
                            sum.Add(inputArray[i] + inputArray[i + 1]);
                            i++;
                        }
                        inputArray = sum;
                    }
                    else
                    {
                        inputArray.Add(0);
                        for (int i = 0; i < inputArray.Count; i++)
                        {
                            sum.Add(inputArray[i] + inputArray[i + 1]);
                            i++;
                        }
                        inputArray = sum;
                    }
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine("[" + string.Join(", ",inputArray) + "]");
        }
    }
}
