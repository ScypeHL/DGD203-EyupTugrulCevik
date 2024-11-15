using System;
using static System.Formats.Asn1.AsnWriter;

namespace Pro
{
    internal class CarSample : Vehicle
    {
        private Engine engine;
        Random rng = new Random();
        private Storages storages = new Storages();
        private string Store;

        string[] colorList = {"Black", "White", "Red", "Green", "Blue"};
        public CarSample(float fuel, float fuelTank, Engine engineType, string store) 
        {
            Color = colorList[rng.Next(0, 4)];
            fuel = Math.Clamp(fuel, 0f, fuelTank);

            engine = engineType;
            Fuel = fuel;
            FuelTank = fuelTank;
            Store = store;
        }
        
        public void runCar() 
        {
            engine.start();

            Console.WriteLine("This is the information of " + Color + " " + EngineName + " car");
            Console.WriteLine("");
        }
    }
}
