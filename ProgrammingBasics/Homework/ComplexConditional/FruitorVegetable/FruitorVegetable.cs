using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitorVegetable
{
    class FruitorVegetable
    {
        static void Main(string[] args)
        {
            var entry = Console.ReadLine();
            if (entry == "banana" || entry == "apple" || entry == "kiwi" || entry == "cherry" || entry == "lemon" || entry == "grapes") Console.WriteLine("fruit");
            else if (entry == "tomato" || entry == "cucumber" || entry == "pepper" || entry == "carrot") Console.WriteLine("vegetable");
            else Console.WriteLine("unknown");
        }
    }
}
