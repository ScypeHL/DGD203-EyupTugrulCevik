using System;
using System.Drawing;

namespace Pro
{
    public class Vehicle
    {
        public static float Fuel { get; protected set; }
        public static string Color { get; protected set; }
        public static float FuelTank { get; protected set; }
        public static string EngineName { get; protected set; }
        
        protected static List<string> Storage = [];

        protected static List<string> items = [];

        protected static List<string> Inventory = [];

    }


}
