using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 15;
            if (minutes >= 60)
            {
                hours = hours + 1;
                minutes = minutes - 60;
                Console.WriteLine("{0}:{1:00}",hours,minutes);
            }
            else
                Console.WriteLine("{0}:{1:00}", hours, minutes);
        }
    }
}
