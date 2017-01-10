using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate = System.DateTime.Parse(Console.ReadLine());
            DateTime result = birthDate.AddDays(999);
            Console.WriteLine("{0:dd-MM-yyyy}", result);
        }
        }
}
