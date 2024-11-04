using System;

namespace Pro
{
    public class Player
    {
        public string name { get; private set; }
        public int age { get; private set; }
        string nameOut;
        int ageOut;
        public Player(string name = "Makato Yuki", int age = 18)
        {
        }

        public void ChSelect() 
        {
            sName();
            void sName() {
                Console.WriteLine("Enter you name:");
                nameOut = Console.ReadLine();
                if (nameOut == null || nameOut == "")
                {
                    Console.WriteLine("You name yourself empty, please enter a name");
                    sName();
                }
                else { 
                    name = nameOut;
                    sAge();
                }
            }
            
            void sAge() {
                Console.WriteLine("Enter your age");
                if (int.TryParse(Console.ReadLine(), out int ageOut))
                {
                    age = ageOut;
                }
                else
                {
                    Console.WriteLine("Please enter a proper number for your age");
                    sAge();
                }
            Console.WriteLine("Your name is " + name + " and you are " + age +" years old");


           
            }
        }
    }
}
