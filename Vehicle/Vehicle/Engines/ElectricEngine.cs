using System;
using System.Security.Cryptography.X509Certificates;

namespace Pro
{
    internal class ElectricEngine : Engine
    {
        public ElectricEngine() 
        {
            Hp = 350;
            Ef = 0.5f;
            EngineName = "Electric";

        }

        public override void fuelCheck()
        {
            Console.WriteLine(Fuel + "kw/" + FuelTank + "kw");
            Console.WriteLine("Tank is " + Fuel / FuelTank * 100 + "% full");
        }

    }
}