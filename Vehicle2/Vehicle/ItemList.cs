using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class ItemList: Vehicle
    {
        public void setList()
        {
            items.Add("7.62 Rifle");
            items.Add("7.62 Ammo");
            items.Add("HE Granade");
            items.Add("Medicine");
            items.Add("Water");
            items.Add("Food");
            items.Add("Hammer");
            items.Add("Screwdriver");
            items.Add("Knife");
        }
    }
}
