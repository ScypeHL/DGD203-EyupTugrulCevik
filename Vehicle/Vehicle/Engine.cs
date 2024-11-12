using System;

namespace Pro
{
    internal class Engine: Vehicle
    {
        public bool isRunning;


        public Engine() 
        {
            if (isRunning)
            {
                Console.WriteLine("Car started to work");
                Console.WriteLine($"The car creates {Hp} horsepower");
            }
        }
        public virtual void start() { 
            isRunning = true;
            hpCheck();
            fuelCheck();
            range();
        }

        public void stop()
        {
            isRunning = true;
            Console.WriteLine("The engine has stopped");
        }

        public void hpCheck() 
        {
            Console.WriteLine("That engine generates " + Hp + " horsepower");
        }
        public virtual void range()
        {
            Console.WriteLine("With that fuel this car can go for " + Fuel / Ef + "km");
        }

        public virtual void fuelCheck() 
        {
            Console.WriteLine(Fuel + "L/" + FuelTank + "L");
            Console.WriteLine("Tank is " + Fuel / FuelTank * 100 + "% full");
        }
    }
}
