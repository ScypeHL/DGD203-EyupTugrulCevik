using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Seats: Vehicle
    {
        int slot = 5;
        int slotTotal = 0;
        public string slotName;
        string item;
        public int slotLimit;
        string readCheck;
        public List<string> Inv = new List<string>();
        public Seats()
        {

        }

        public void start()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.Write("\n [" + items[i] + "]");
            }
            getItem();
        }
        
        public void getItem()
        {
            Console.WriteLine("\nPlease select the item you want to have");
            item = Console.ReadLine();
            if (item is not null && item is not "" && items.Contains(item))
            {
                setItem();
            }
            else
            {
                Console.WriteLine("Enter a valid item name");
                getItem();
            }
        }
        
        public virtual void setItem()
        {

            if (slotTotal + slot <= slotLimit)
            {
                slotTotal = slotTotal + slot;
                Console.Write("");
                Console.WriteLine($"{item} is added into the inventory");
                Inv.Add(item);
                check();
            }
            else
            {
                Console.Write("");
                Console.WriteLine($"You do not have enough space at {slotName} ");
                check();
            }
        }

        public void check()
        {
            Console.Write("");
            Console.WriteLine("Do you want to have more items?");
            Console.WriteLine("[Yes/Y] [No/N]");

            readCheck = Console.ReadLine();
            if (readCheck == "Yes" ^ readCheck == "Y" ^ readCheck == "yes" ^ readCheck == "y")
            {
                getItem();
            }
            else if (readCheck == "No" ^ readCheck == "N" ^ readCheck == "no" ^ readCheck == "n")
            {
                print();
            }
            else
            {
                Console.Write("Please enter your choice correctly");
                check();
            }

        }

        public void print()
        {
            Console.Write("");
            Console.Write("You have those items in your seat");
            for (int i = 0; i < Inv.Count; i++)
            {
                Console.Write("\n [" + Inv[i] + "]");
            }
        }
    }
}
