using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int treated = 0;
            int untreated = 0;
            int doctors = 7;
            for (int i = 1; i <= days; i++)
            {
                if ((i % 3 == 0) && (untreated >= treated))
                {
                    doctors++;
                }
                int patientsToday = int.Parse(Console.ReadLine());
                if (patientsToday >= doctors)
                {
                    treated += doctors;
                    untreated += (patientsToday - doctors);
                }
                else
                {
                    treated += patientsToday;
                }

            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
