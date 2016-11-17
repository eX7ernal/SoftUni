using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class TheFirm
    {
        static void Main(string[] args)
        {
            int hourNeeded = int.Parse(Console.ReadLine());
            int daysAvailable = int.Parse(Console.ReadLine());
            int employeesOver = int.Parse(Console.ReadLine());
            double workTime = (daysAvailable * 0.90) * 8;
            double overtimeHours = employeesOver * (2 * daysAvailable);
            double totalHours = Math.Floor(workTime + overtimeHours);
            int diference = (int)(hourNeeded - totalHours);
            if (diference <= 0)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Abs(diference));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(diference));
            }
        }
    }
}
