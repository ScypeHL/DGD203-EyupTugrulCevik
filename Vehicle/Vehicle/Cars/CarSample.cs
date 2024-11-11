using System;

namespace Pro
{
    internal class CarSample: Vehicle
    {
        private Engine engine;

        public CarSample(float fuel,int hp, Engine engineType) 
        {
            fuel = Math.Clamp(fuel, 0f, 100f);
            engine = engineType;
            Fuel = fuel;
            Hp = hp;
            
        }
        public void runCar() 
        {
            engine.start();
            Console.WriteLine(Fuel);
        }

    }
}
