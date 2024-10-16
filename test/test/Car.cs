using System;

namespace Pro
{
    public class Car
    {
        public string name;
        public int year;
        public int hp;
        public float fuel;
        public float ef;

        public Car(string name, int year, int hp, float fuel, float ef)
        {
            this.name = name;
            this.year = year;
            this.hp = hp;
            this.fuel = fuel;
            this.ef = ef;
        }

        void Condition()
        {

        }

        public void Info()
        {
            Console.WriteLine("This car's name is " + name);
            Console.WriteLine("This car was made in " + year);
            Console.WriteLine("This car has " + hp + " horsepowers");
            Console.WriteLine("This car has " + fuel + "L fuel tank");
            Console.WriteLine("This car consumes " + ef + "L of fuel per 100 kilometers");
            Console.WriteLine("This car can go for " + (fuel * 100 / ef) + " kilometers");
            Console.WriteLine("");
        }
    }
}
