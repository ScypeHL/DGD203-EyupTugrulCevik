using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Pro
{
    internal class Generator: Vehicle
    {
        private string getEngineName;
        private string engine;
        private string fuelUnit;
        private int setTank;
        private float setFuel;
        private string kit;
        private string setkit;
        private float dieselCost = 12;
        private float hydrogenCost = 50;
        private float electricCost = 4;
        private float cost;
        public float money = 1000;

        
        List<int> tank = new List<int>();
        Random rng = new Random();
        private Storages storages = new Storages();
        
        public Generator() 
        {
            tank.Add(50);
            tank.Add(60);
            tank.Add(70);
            tank.Add(80);
            tank.Add(90);
        }

        public void startGame() 
        {
            setTank = tank.ElementAt(rng.Next(0, 4));
            Console.WriteLine("Those are the engine types you can select:");
            Console.WriteLine("> [Electric] Engine");
            Console.WriteLine("> [Diesel] Engine");
            Console.WriteLine("> [Hydrogen] Engine");
            engineName();

            Console.WriteLine("");
            fuelType();
            Console.WriteLine($"Your car can hold {setTank} {fuelUnit}");
            purchaseFuel();

            Console.WriteLine("");
            Console.WriteLine("There is three starter packs you can select");
            Console.WriteLine("[Weapon] kit contains: 7.62 Rifle, 7.62 Ammo, He Granade");
            Console.WriteLine("[Source] kit contains: Food, Water, Medicine");
            Console.WriteLine("[Gadget] kit contains: Hammer, Knife, Screwdriver");
            getStore();
            engineCheck();



        }

        // Functions
        #region Functions
        void fuelType() 
        {
            if (getEngineName == "Diesel" ^ getEngineName == "Diesel Engine") 
            {
                Console.WriteLine("1 liter of diesel costs " + dieselCost);
                fuelUnit = "Liter";
                cost = dieselCost;
            }
            else if (getEngineName == "Hydrogen" ^ getEngineName == "Hydrogen Engine")
            {
                Console.WriteLine("1 Liter of hydrogen costs " + hydrogenCost);
                fuelUnit = "Liter";
                cost = hydrogenCost;
            }
            else if (getEngineName == "Electric" ^ getEngineName == "Electric Engine")
            {
                Console.WriteLine("1 Kw of electric costs " + electricCost);
                fuelUnit = "Kw";
                cost = electricCost;
            }
        }
        
        void engineName() 
        {
            Console.WriteLine("Choose an engine type");
            getEngineName = Console.ReadLine();
            if (getEngineName == "Diesel" ^ getEngineName == "Diesel Engine" ^ getEngineName == "Hydrogen" ^ getEngineName == "Hydrogen Engine" ^ getEngineName == "Electric" ^ getEngineName == "Electric Engine")
            {
                return;
            }
            else
            {
                Console.WriteLine("Please type again");
                engineName();
            }
        }
        
        void purchaseFuel() 
        {
            Console.WriteLine($"Please purchase fuel by entering {fuelUnit}. You have " + money + " money");
            if (int.TryParse(Console.ReadLine(), out int checkFuel))
            {
                if (checkFuel > setTank)
                {
                    Console.WriteLine("You cant purchase more than your can can hold.");
                    purchaseFuel();
                }
                else
                {
                    if (cost * checkFuel > money)
                    {
                        Console.WriteLine("Not enough money. Tyr purchasing less fuel");
                        purchaseFuel();
                    }
                    else
                    {
                        setFuel = checkFuel;
                        money = money - cost * setFuel;
                        Console.WriteLine($"You have {money} money left");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a proper number to purchase fuel");
                purchaseFuel();
            }
        }

        public void getStore()
        {
            Console.WriteLine("Please select a starter pack");
            setkit = Console.ReadLine();
            if (setkit == "Weapon")
            { 
                storages.addWeapon(); 
            }
            else if (setkit == "Gadget")
            { 
                storages.addGadget(); 
            }
            else if (setkit == "Source")
            { 
                storages.addSource(); 
            }
            else
            {   Console.WriteLine("Please choose again");
                getStore();
            }
        }
        #endregion
        void engineCheck() 
        {
            if (getEngineName == "Electric Engine" ^ getEngineName == "Electric")
            {
                CarSample firstCar = new CarSample(setFuel, setTank, new ElectricEngine(), kit);
                firstCar.runCar();
            }
            else if (getEngineName == "Diesel Engine" ^ getEngineName == "Diesel")
            {
                CarSample firstCar = new CarSample(setFuel, setTank, new DieselEngine(), kit);
                firstCar.runCar();
            }
            else if (getEngineName == "Hydrogen Engine" ^ getEngineName == "Hydrogen")
            {
                CarSample firstCar = new CarSample(setFuel, setTank, new HydrogenEngine(), kit);
                firstCar.runCar();
            }
            else
            {
                Console.WriteLine(getEngineName);
                Console.WriteLine("nope");
            }
        }
    }
}
