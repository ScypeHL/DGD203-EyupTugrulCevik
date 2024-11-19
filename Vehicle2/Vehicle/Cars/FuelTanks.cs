using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class FuelTanks: Vehicle
    {
        public FuelTanks() 
        {

        }

        public void fuelType(string getEngineName, string fuelUnit, float cost, float totalCost)
        {
                Console.WriteLine($"1 {fuelUnit} of {getEngineName} costs " + cost);
                totalCost = cost;
        }

        public void purchaseFuel(string fuelUnit, float money, float cost)
        {
            Console.WriteLine($"Please purchase fuel by entering {fuelUnit}. You have " + money + " money");
            if (int.TryParse(Console.ReadLine(), out int checkFuel))
            {
                if (checkFuel > FuelTank)
                {
                    Console.WriteLine("You cant purchase more than your can can hold.");
                    purchaseFuel(fuelUnit, money, cost);
                }
                else
                {
                    if (cost * checkFuel > money)
                    {
                        Console.WriteLine("Not enough money. Tyr purchasing less fuel");
                        purchaseFuel(fuelUnit, money, cost);
                    }
                    else
                    {
                        Fuel = checkFuel;
                        money = money - cost * Fuel;
                        Console.WriteLine($"You have {money} money left");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a proper number to purchase fuel");
                purchaseFuel(fuelUnit, money, cost);
            }
        }

    }
}
