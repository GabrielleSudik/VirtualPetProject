using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProject

    //this program will let you choose and manipulate a virtual pet
    //three fields and properties
    //three methods
    //one+ constructor
    //updated pet status
    //action selection menu
{
    class Program
    { 
        static void Main(string[] args)  //intro and initial pet selection
        {
            Console.WriteLine("Welcome to the Gatlantiss Pet Store!");
            Console.WriteLine("The only shop offering REAL LIVE DINOSAURS!");
            Console.WriteLine();

            Console.WriteLine("First things first...");
            Console.WriteLine("Would you like to adopt a \"T Rex\" or a \"Tricerotops\"?");
            string breed = Console.ReadLine();  //breed will pass to the constructor.
                                                //constructor will set initial stats depending on choice

            Console.WriteLine($"\nCongrats! You now own a beautiful {breed}!");

            Console.WriteLine("What would you like to name it?");
            string name = Console.ReadLine();
            Console.WriteLine();

            Pet dino = new Pet(breed); //creates instance of dino

            bool isAlive = true;

            //make this a loop somehow

            while (isAlive == true)  //loop will run until the pet is dead (choice SendToFarm)
            {
                dino.PetStatus(name);  //will display pet's moods

                Console.WriteLine($"OK, now what would you like to do with {name}? Choose from:");
                Console.WriteLine("   1.  Learn about your pet");
                Console.WriteLine("   2.  Feed your pet");
                Console.WriteLine("   3.  Walk your pet");
                Console.WriteLine("   4.  Play with your pet");
                Console.WriteLine("   5.  Send your pet to the farm. (quit)");

                int choice = int.Parse(Console.ReadLine()); //user chooses what to do with pet

                if (choice == 1)

                { dino.AboutPet(breed); } //method displays unchanging facts
                
                if (choice == 2)
                {
                    dino.FeedPet(breed); //method feeds pet, changes danger/hunger level
                }

                if (choice == 3)
                {
                    dino.WalkPet();  //method allows or disallows walking, based on mood of pet
                }

                if (choice == 4)
                {
                    dino.PetPet();  //method increases or decreases pet happiness
                }

                if (choice == 5)
                {
                    ToTheFarm(name);  //method kills pet
                    isAlive = false;  //ends loop (and therefore ends game)
                }

                Console.ReadLine();
            }
        }

        static void ToTheFarm(string name) //this method kills pet/ends game
        {
            Console.WriteLine("\nYou \"send your pet to the farm.\"");
            Console.WriteLine($"{name} is now dead.");
            Console.WriteLine("You are a terrible person.");
            Console.WriteLine();
            Console.WriteLine("GAME OVER.");
        }
    }
}
