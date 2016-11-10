using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double totalPlays, weekendsPlays, holidayPlays;
            if (year == "normal")
            {
                weekendsPlays = (48 - h) * (3.0 / 4.0);
                holidayPlays = p * 2.0/3.0;
                totalPlays = weekendsPlays + h + holidayPlays;
                Console.WriteLine(Math.Truncate(totalPlays));
            }
            else if (year == "leap")
            {
                weekendsPlays = (48 - h) * (3.0 / 4.0);
                holidayPlays = p * 2.0 / 3.0;
                totalPlays = weekendsPlays + h + holidayPlays;
                totalPlays += 0.15 * totalPlays;
                Console.WriteLine(Math.Truncate(totalPlays));
            }
        }
    }
}
