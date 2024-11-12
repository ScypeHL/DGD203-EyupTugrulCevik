using System;

namespace Pro
{
    internal class CarSample : Vehicle
    {
        private Engine engine;
        Random rng = new Random();

        string[] colorList = {"Black", "White", "Red", "Green", "Blue"};
        public CarSample(float fuel, float fuelTank, Engine engineType) 
        {
            Color = colorList[rng.Next(0, 4)];
            fuel = Math.Clamp(fuel, 0f, fuelTank);

            engine = engineType;
            Fuel = fuel;
            FuelTank = fuelTank;
        }
        
        public void runCar() 
        {
            engine.start();
            Console.WriteLine("This is the information of " + Color + " " + EngineName + " car");
            Console.WriteLine("");
        }

    }
}
