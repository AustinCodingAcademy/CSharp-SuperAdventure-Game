using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class InventoryItem
    {
        public Item Details { set; get; }
        public int Quantity { get; set; }

        public InventoryItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;

        }   
        

    }
}
