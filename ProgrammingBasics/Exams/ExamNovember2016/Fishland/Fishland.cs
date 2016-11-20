using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            double skumriq = double.Parse(Console.ReadLine());
            double caca = double.Parse(Console.ReadLine());
            double palamud = double.Parse(Console.ReadLine());
            double safrid = double.Parse(Console.ReadLine());
            double midi = double.Parse(Console.ReadLine());
            double total = 0;
            double palamudTotal = (skumriq + skumriq * 0.60) * palamud;
            double safridTotal = (caca + caca * 0.80) * safrid;
            double midiTotal = 7.50 * midi;
            total = palamudTotal + safridTotal + midiTotal;
            Console.WriteLine("{0:f2}",total);
        }
    }
}
