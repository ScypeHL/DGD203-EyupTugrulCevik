using System;
using System.ComponentModel;

namespace Pro
{
    internal class Engine: Vehicle
    {
        public bool isRunning;
        public float hp;
        public float ef;

        public Engine() 
        {
            if (isRunning)
            {
                Console.WriteLine("Car started to work");
            }
        }
        public virtual void start() { 
            isRunning = true;
            Console.WriteLine("");
            
            hpCheck();
            fuelCheck();
            range();
        }

        public void stop()
        {
            isRunning = false;
            Console.WriteLine("The engine has stopped");
        }

        #region Checks
        public void hpCheck() 
        {
            Console.WriteLine("That "+ EngineName +" engine generates " + hp + " horsepower");
        }
        public virtual void range()
        {
            Console.WriteLine("With that fuel this car can go for " + Fuel * 100 / ef + "km");
        }

        public virtual void fuelCheck() 
        {
            Console.WriteLine(Fuel + "L/" + FuelTank + "L - Tank is " + Fuel / FuelTank * 100 + "% full");
        }
        #endregion
    }
}
