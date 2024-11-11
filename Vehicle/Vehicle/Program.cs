using System;

namespace Pro
{
    class Program()
    {

        static void Main(string[] args)
        {
            CarSample firstCar = new CarSample(100f, 350, new ElectricEngine());
            firstCar.runCar();

            CarSample secondCar = new CarSample(4f, 90, new DieselEngine());
            secondCar.runCar();

            CarSample thirdCar = new CarSample(4f, 110, new HydrogenEngine());
            thirdCar.runCar();
        }

    }
}