using System;
using System.Security.Cryptography.X509Certificates;

namespace Pro
{
    internal class ElectricEngine : Engine
    {
        public ElectricEngine() 
        {
            hp = 350;
            ef = 7f;
            EngineName = "Electric";

        }

        public override void fuelCheck()
        {
            Console.WriteLine(Fuel + "kw/" + FuelTank + "kw - Battery is " + Fuel / FuelTank * 100 + "% full");
        }

    }
}