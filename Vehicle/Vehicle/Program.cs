using System;

namespace Pro
{
    class Program()
    {

        static void Main(string[] args)
        {
            CarSample firstCar = new CarSample(10f, 27,new ElectricEngine());
            firstCar.runCar();

            CarSample secondCar = new CarSample(16f, 60,new DieselEngine());
            secondCar.runCar();

            CarSample thirdCar = new CarSample(4f, 30,new HydrogenEngine());
            thirdCar.runCar();
        }

    }
}