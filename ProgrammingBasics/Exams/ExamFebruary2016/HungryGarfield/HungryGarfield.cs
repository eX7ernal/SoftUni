using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class HungryGarfield
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal exrate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            long pizzaQuantity = long.Parse(Console.ReadLine());
            long lasagnaQuantity = long.Parse(Console.ReadLine());
            long sandwichQuantity = long.Parse(Console.ReadLine());
            decimal total = money * exrate;
            decimal productTotal = (pizzaPrice * pizzaQuantity) + (lasagnaPrice * lasagnaQuantity) + (sandwichPrice * sandwichQuantity);
            decimal moneyLeft = total - productTotal;
            if (moneyLeft >= 0)
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", moneyLeft / exrate);
            else
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", Math.Abs(moneyLeft / exrate));
        }
    }
}
