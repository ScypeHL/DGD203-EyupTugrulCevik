using System;

namespace Pro
{
    public class Car
    {
        public string name;
        public int year;
        public int hp;
        public float fuel;
        public int ef;
        private int x;
        private float offset;
        private float consm;
        Random rng = new Random();

        public Car(string name, int year, int hp, float fuel, int ef)
        {
            this.name = name;
            this.year = year;
            this.hp = hp;
            this.fuel = fuel;
            this.ef = ef;
        }

        public void Run() 
        {
            Console.WriteLine("Please enter the lenght of the route in kilometers");
            x = Convert.ToInt32(Console.ReadLine());

            while (x > 0)
            {
                offset = rng.Next (ef - (ef*2/5), ef + (ef * 2/5));
                Console.WriteLine("We went a kilometer using " + offset / 100 + "L of fuel");
                Console.WriteLine("We have " + (x - 1) + "km left");
                Console.WriteLine("");
                consm = consm + offset / 100;
                x = x - 1;

            }
            Console.WriteLine("At the end of the way, we spent " + consm + "L of fuel");
        
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
