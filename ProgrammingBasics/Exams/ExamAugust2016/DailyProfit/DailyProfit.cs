using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProfit
{
    class DailyProfit
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            double dailyProfit = double.Parse(Console.ReadLine());
            double xRate = double.Parse(Console.ReadLine());
            double monthlyProfit = workDays * dailyProfit;
            double yearlyProfit = (monthlyProfit * 12) + (monthlyProfit * 2.5);
            double taxes = yearlyProfit * 0.25;
            double netProfit = yearlyProfit - taxes;
            double averageDaily = (netProfit / 365) * xRate;
            Console.WriteLine("{0:f2}", averageDaily);
        }
    }
}
