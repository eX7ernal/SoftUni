using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            int seconds = int.Parse(Console.ReadLine());
            var timespan = TimeSpan.FromSeconds(seconds);
            Console.WriteLine(timespan.ToString(@"mm\:ss"));
        }
    }
}
