using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            bool check;
            for (int i = 1; i <= n; i++)
            {
                int special = 0;
                number = i;
                while (number > 0)
                {
                    special += number % 10;
                    number = number / 10;
                }
                if (special == 5 || special == 7 || special == 11)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                Console.WriteLine("{0} ->{1}", i, check);
            }
        }
    }
}
