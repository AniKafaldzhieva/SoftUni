using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariables
{
    class BoolVariables
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (Convert.ToBoolean(word))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
