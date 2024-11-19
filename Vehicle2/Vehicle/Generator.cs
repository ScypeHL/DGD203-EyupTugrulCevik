using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Pro
{
    internal class Generator: Vehicle
    {
        private string getEngineName;
        private string getSlotName;
        private string itemName;
        public string fuelUnit;
        private float cost;
        private float totalCost;
        public float money = 1000;

        private int t1;
        private int t2;


        Random rng = new Random();
        private FuelTanks fT = new FuelTanks();
        private ItemList itemList = new ItemList();

        Storage stor1 = new Storage(new Seat1());
        Storage stor2 = new Storage(new Seat2());

        public Generator() 
        {
            itemList.setList();
        }

        public void startGame() 
        {
            Console.WriteLine("Those are the engine types you can select:");
            Console.WriteLine("> [Electric] Engine");
            Console.WriteLine("> [Diesel] Engine");
            Console.WriteLine("> [Hydrogen] Engine");
            engineName();

            Console.WriteLine("");
            tankList(t1, t2);
            fT.fuelType(getEngineName, fuelUnit, cost, totalCost);
            Console.WriteLine($"Your car can hold {FuelTank} {fuelUnit}");
            fT.purchaseFuel(fuelUnit, money, cost);

            Console.WriteLine("");
            checkSlot();
            engineCheck();



        }

        // Functions
        #region Functions
        
        void engineName() 
        {
            Console.WriteLine("Choose an engine type");
            getEngineName = Console.ReadLine();

            if (getEngineName == "Diesel")
            {;
                fuelUnit = "Liter";
                cost = 10;
                t1 = 4;
                t2 = 7;
            }
            else if (getEngineName == "Hydrogen")
            {;
                fuelUnit = "Liter";
                cost = 50;
                t1 = 2;
                t2 = 5;
            }
            else if (getEngineName == "Electric")
            {;
                fuelUnit = "Kw";
                cost = 4;
                t1 = 9;
                t2 = 20;
            }
            else
            {
                Console.WriteLine("Please type again");
                engineName();
            }
        }


        public void tankList(int t1, int t2) 
        {
            FuelTank = rng.Next(t1, t2) * 10;
        }
        
        #endregion
        
        
        void checkSlot()
        {
            Console.WriteLine("[Seat 1]");
            Console.WriteLine("[Seat 2]");
            Console.WriteLine("Please select the seat you want to stock your items");

            getSlotName = Console.ReadLine();
            if (getSlotName == "Seat 1" ^ getSlotName == "Seat1" ^ getSlotName == "seat 1" ^ getSlotName == "seat1" && getSlotName is not null)
            {
                stor1.deploy();
            }
            else if (getSlotName == "Seat 2" ^ getSlotName == "Seat2" ^ getSlotName == "seat 2" ^ getSlotName == "seat2" && getSlotName is not null)
            {
                stor2.deploy();
            }
            else
            {
                Console.WriteLine("No seat with that name found");
                Console.WriteLine("Please make sure you enter the name correctly");
                checkSlot();
            }
        }

        void engineCheck() 
        {
            if (getEngineName == "Electric Engine" ^ getEngineName == "Electric")
            {
                CarSample firstCar = new CarSample(Fuel, FuelTank, new ElectricEngine());
                firstCar.runCar();
            }
            else if (getEngineName == "Diesel Engine" ^ getEngineName == "Diesel")
            {
                CarSample firstCar = new CarSample(Fuel, FuelTank, new DieselEngine());
                firstCar.runCar();
            }
            else if (getEngineName == "Hydrogen Engine" ^ getEngineName == "Hydrogen")
            {
                CarSample firstCar = new CarSample(Fuel, FuelTank, new HydrogenEngine());
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
