using System;


namespace Pro
{
    internal class ElectricEngine: Engine
    {
        public ElectricEngine() 
        {
            ef = 0.5f;
        }
        
        public override void start()
        {
            base.start();
            fuelStatus();
        }

        public override void fuelStatus() 
        {
            Console.WriteLine("The Battery is fine");
        }
    }
}
