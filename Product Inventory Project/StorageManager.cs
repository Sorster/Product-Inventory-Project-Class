using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_Project
{
    public class StorageManager
    {
        public void ShowFruit(Fruits fruit)
        {
            Console.WriteLine(fruit._ID);
            Console.WriteLine($"Quantity: {fruit._count}");
            Console.WriteLine($"Price: {fruit._price}");
        }

        public int Cost(Fruits fruit)
        {
            return fruit._count * fruit._price;
        }
    }
}
