﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2kPlus1
{
    class Sequence2kPlus1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            while (num <= n)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
