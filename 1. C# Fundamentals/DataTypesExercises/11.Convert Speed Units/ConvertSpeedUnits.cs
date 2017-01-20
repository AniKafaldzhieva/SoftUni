using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            
            float kilometersPerHours = (distance / 1000f) / (hours + minutes / 60f + seconds / 3600f);
            float metersPerSeconds = kilometersPerHours / 3.6f;
            float milesPerHours = (distance / 1609f) / (hours + minutes / 60f + seconds / 3600f);

            Console.WriteLine(metersPerSeconds);
            Console.WriteLine(kilometersPerHours);
            Console.WriteLine(milesPerHours);
        }
    }
}
