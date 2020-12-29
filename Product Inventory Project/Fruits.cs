using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_Project
{
    public class Fruits : StorageManager
    {
        public int _count { get; set; }

        public string _ID { get; set; }

        public int _price { get; set; }

        public Fruits() 
        {

        }

        public Fruits(string ID)
        {
            _ID = ID;
        }

        public Fruits(string ID, int count)
        {
            _count = count;
            _ID = ID;
        }

        public Fruits(string ID, int count, int price)
        {
            _count = count;
            _ID = ID;
            _price = price;
        }
    }
}
