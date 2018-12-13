using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    public class Inventory
    {
        public IEnumerable<Item> EquippedItems { get; set; }
        public IEnumerable<Item> ItemsInBackpack { get; set; }
    }
}
