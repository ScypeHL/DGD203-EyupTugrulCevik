using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Storages: Vehicle
    {
        public static string weapon1 = "7.62 Rife";
        
        public Storages()
        {
            return;
        }

        public void addWeapon()
        {
            Storage.Add("7.62 Rifle");
            Storage.Add("7.62 Ammo");
            Storage.Add("HE Granade");
        }
        public void addSource()
        {
            Storage.Add("Medicine");
            Storage.Add("Water");
            Storage.Add("Food");
        }
        public void addGadget()
        {
            Storage.Add("Hammer");
            Storage.Add("Screwdriver");
            Storage.Add("Knife");

        }

        private void printStorage() 
        {
            foreach (var i in Vehicle.Storage)
            {
                Console.WriteLine(">" + i);
            }
            Storage.Clear();
        }
    }
}
