using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator1
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int elevator = int.Parse(Console.ReadLine());

            if(people>elevator)
            {
                int courses = (int)Math.Ceiling((double)people / elevator);
                Console.WriteLine(courses);
            }
            else
            {
                int courses = (int)Math.Ceiling((double)elevator % people);
                Console.WriteLine(courses);
            }
        }
    }
}
