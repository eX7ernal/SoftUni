using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            town = town.ToLower();
            var sales = double.Parse(Console.ReadLine());
            double commision = -1;
            if (town == "sofia")
            {
                if (0 <= sales && sales <= 500) commision = 0.05;
                else if (500 < sales && sales <= 1000) commision = 0.07;
                else if (1000 < sales && sales <= 10000) commision = 0.08;
                else if (500 <= sales) commision = 0.12;
            }
            else if (town == "varna")
            {
                if (0 <= sales && sales <= 500) commision = 0.045;
                else if (500 < sales && sales <= 1000) commision = 0.075;
                else if (1000 < sales && sales <= 10000) commision = 0.10;
                else if (500 <= sales) commision = 0.13;
            }
            else if (town == "plovdiv")
            {
                if (0 <= sales && sales <= 500) commision = 0.055;
                else if (500 < sales && sales <= 1000) commision = 0.08;
                else if (1000 < sales && sales <= 10000) commision = 0.12;
                else if (500 <= sales) commision = 0.145;
            }
            else if (commision == -1) Console.WriteLine("error");
            Console.WriteLine("{0:f2}",sales*commision);
        }
    }
}
