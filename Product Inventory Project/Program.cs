using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruits apples = new Fruits("Apples", 100, 2);
            Fruits bananas = new Fruits("Bananas", 250, 3);
            Fruits oranges = new Fruits("Oranges", 75, 1);

            apples.ShowFruit(apples);
            Console.WriteLine($"Total price: {apples.Cost(apples)}");

            Console.WriteLine();
            bananas.ShowFruit(bananas);
            Console.WriteLine($"Total price: {bananas.Cost(bananas)}");

            Console.WriteLine();
            oranges.ShowFruit(oranges);
            Console.WriteLine($"Total price: {oranges.Cost(oranges)}");

            int totalPrice = apples.Cost(apples) + bananas.Cost(bananas) + oranges.Cost(oranges);
            Console.WriteLine($"\nTotal price of all fruits: {totalPrice}");

            Console.ReadLine();
        }
    }

  
}