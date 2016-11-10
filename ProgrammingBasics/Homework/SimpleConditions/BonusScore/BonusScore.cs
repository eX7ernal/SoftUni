using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            var points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            double totalPoints = 0;
            if (points < 100)
            {
                bonusPoints = 5;
            }
            else if (points>100 & points<1000)
            {
                bonusPoints = (0.20 * points);
            }
            else if (points > 1000)
            {
                bonusPoints = 0.10 * points;
            }
            if (points % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (points % 2 == 1 & points % 5 == 0)
            {
                bonusPoints = bonusPoints + 2;
            }
            totalPoints = points + bonusPoints;
            Console.WriteLine(bonusPoints);
            Console.WriteLine(totalPoints);
        }
    }
}
