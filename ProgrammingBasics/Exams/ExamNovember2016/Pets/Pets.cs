using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodTotal = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());
            double eatenFood = 0;
            double dogTotal = 0;
            double catTotal = 0;
            double turtleTotal = 0;
            dogTotal = dogFood * days;
            catTotal = catFood * days;
            turtleTotal = (turtleFood * days) * 0.001;
            //Console.WriteLine(dogTotal);
            //Console.WriteLine(dogTotal);
            //Console.WriteLine(turtleTotal);
            eatenFood = dogTotal + catTotal + turtleTotal;
            if (eatenFood > foodTotal)
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Abs(Math.Ceiling(eatenFood - foodTotal)));
            }
            else
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodTotal - eatenFood));
            }

        }
    }
}
