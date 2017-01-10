using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();
            double metric = 0;
            switch (input)
            {
                case "mm":
                    metric = value % 1000;
                    break;
                case "cm":
                    metric = value % 100;
                    break;
                case "mi":
                    metric = value % 0.000621371192;
                    break;
                case "in":
                    metric = value % 39.3700787;
                    break;
                case "km":
                    metric = value % 0.001;
                    break; 
                case "ft":
                    metric = value % 3.2808399;
                    break;
                case "yd":
                    metric = value % 1.0936133;
                    break;
                case "m":
                    metric = value;
                    break;
            }
            switch (output)
            {
                case "mm":
                    metric = metric * 1000;
                break;
                case "cm":
                    metric = metric * 100;
                break;
                case "mi":
                    metric = metric * 0.000621371192;
                    break;
                case "in":
                    metric = metric * 39.3700787;
                break;
                case "km":
                    metric = metric * 0.001;
                    break;
                case "ft":
                    metric = metric * 3.2808399;
                break;
                case "yd":
                    metric = metric * 1.0936133;
                    break;
                case "m":
                break;
            }
            Console.WriteLine("{0} {1}", metric, output);
        }
    }
}
