using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;
            switch (month)
            {
                case "May":
                    studioPrice = days * 50;
                    apartmentPrice = days * 65;
                    break;
                case "June":
                    studioPrice = days * 75.20;
                    apartmentPrice = days * 68.70;
                    break;
                case "July":
                    studioPrice = days * 76;
                    apartmentPrice = days * 77;
                    break;
                case "August":
                    studioPrice = days * 76;
                    apartmentPrice = days * 77;
                    break;
                case "September":
                    studioPrice = days * 75.20;
                    apartmentPrice = days * 68.70;
                    break;
                case "October":
                    studioPrice = days * 50;
                    apartmentPrice = days * 65;
                    break;
                default:
                    break;
            }
            if (month == "May" || month == "October")
            {
                if (days > 7 && days <= 14)
                {
                    studioPrice -= (studioPrice * 0.05);
                }
                else if (days > 14)
                {
                    studioPrice -= (studioPrice * 0.30);
                }
            }
            if (month == "June" || month == "September")
            {
                if (days > 14)
                {
                    studioPrice -= (studioPrice * 0.2);
                }
            }
            if (days > 14)
            {
                apartmentPrice -= (apartmentPrice * 0.1);
            }
            Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
        }
    }
}
