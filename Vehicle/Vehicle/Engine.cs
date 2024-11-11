using System;

namespace Pro
{
    internal class Engine: Vehicle
    {
        public bool isRunning;
        public float ef = 2;
        float fuelRem = Fuel;

        public Engine() 
        {
        }
        public virtual void start() { 
            isRunning = true;
            Console.WriteLine("Car started to work");
            Console.WriteLine($"The car creates {Hp} horsepower");
        }

        public void stop()
        {
            isRunning = false;
            Console.WriteLine("The engine has stopped");
        }

        public virtual void fuelStatus() 
        {
            Console.WriteLine("The fuel level is fine");
        }
        public void runEngine(float fuelRem)
        {
            if (fuelRem > 0 || isRunning == true)
            {
                Console.WriteLine(Fuel);
            }

        }
    }
}
