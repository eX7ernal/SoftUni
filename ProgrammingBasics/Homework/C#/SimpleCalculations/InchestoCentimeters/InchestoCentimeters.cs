﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchestoCentimeters
{
    class InchestoCentimeters
    {
        static void Main(string[] args)
        {
            var inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}
