using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int seniors = int.Parse(Console.ReadLine());
            int youngsters = int.Parse(Console.ReadLine());
            int stays = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            double daylyTransport = 0;
            double transportTotal = 0;
            switch (transport)
            {
                case "train":
                    daylyTransport = (seniors * 24.99) + (youngsters * 14.99);
                    transportTotal = daylyTransport * 2;
                    break;
                case "bus":
                    daylyTransport = (seniors * 32.50) + (youngsters * 28.50);
                    transportTotal = daylyTransport * 2;
                    break;
                case "boat":
                    daylyTransport = (seniors * 42.99) + (youngsters * 39.99);
                    transportTotal = daylyTransport * 2;
                    break;
                case "airplane":
                    daylyTransport = (seniors * 70) + (youngsters * 50);
                    transportTotal = daylyTransport * 2;
                    break;
                default:
                    break;
            }
            if (((seniors + youngsters) > 50) && transport == "train")
            {
                transportTotal = transportTotal * 0.5;
            }
            double hotelStay = stays * 82.99;
            double commision = (transportTotal + hotelStay) * 0.1;
            Console.WriteLine("{0:f2}", transportTotal + hotelStay + commision);
        }
    }
}
