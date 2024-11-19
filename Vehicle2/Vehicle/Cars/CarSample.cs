using System;
using static System.Formats.Asn1.AsnWriter;

namespace Pro
{
    internal class CarSample : Vehicle
    {
        private Engine engine;
        Random rng = new Random();
        private string Store;

        public float Ef;
        public int Hp;

        public float fuelTank;

        string[] colorList = {"Black", "White", "Red", "Green", "Blue"};
        public CarSample(float fuel, float fuelTank, Engine engineType) 
        {
            Color = colorList[rng.Next(0, 4)];
            fuel = Math.Clamp(fuel, 0f, fuelTank);

            engine = engineType;
            Fuel = fuel;
            FuelTank = fuelTank;

            Ef = engineType.ef;
            Hp = engineType.hp;

        }
        
        public void runCar() 
        {
            engine.start();

            Console.WriteLine("This is the information of " + Color + " " + EngineName + " car");
            Console.WriteLine("");
        }
    }
}
