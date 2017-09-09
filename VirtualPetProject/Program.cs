using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First things first...");
            Console.WriteLine("Would you like to adopt a \"T Rex\" or a \"Tricerotops\"?");
            string breed = Console.ReadLine();

            Console.WriteLine($"\nCongrats! You now own a beautiful {breed}!"); //maybe offer choice, trex or steg
                                                                                //then if else depending on choice, with different constructors
                                                                                //one veggie, one beef, etc.

            Console.WriteLine("What would you like to name it?");
            string name = Console.ReadLine();
            Console.WriteLine();

            Pet dino = new Pet();

            //if (breed == "Tricerotops")
            //{
            //    Pet dino = new Pet();
            //}

            bool isAlive = true;

            //make this a loop somehow

            while (isAlive == true)
            {
                Console.WriteLine($"OK, now what would you like to do with {name}? Choose from:");
                Console.WriteLine("   1.  Learn about your pet");
                Console.WriteLine("   2.  Feed your pet");
                Console.WriteLine("   3.  Walk your pet");
                Console.WriteLine("   4.  Play with your pet");
                Console.WriteLine("   5.  Send your pet to the farm.");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)

                { dino.AboutPet(breed); }

                //{
                //    if (breed == "T Rex")
                //    {


                //        dino.AboutPet(breed);
                //    }

                //    if (breed == "Tricerotops")
                //    {
                //        dino.AboutPet();
                //    }
                //}

                if (choice == 2)
                {
                    dino.FeedPet(breed);
                }

                if (choice == 3)
                {
                    dino.WalkPet();
                }

                if (choice == 4)
                {
                    dino.PetPet();
                }

                if (choice == 5)
                {
                    ToTheFarm(name);
                    isAlive = false;
                }

                Console.ReadLine();


            }
        }

        static void ToTheFarm(string name)
        {
            Console.WriteLine("\nYou \"send your pet to the farm.\"");
            Console.WriteLine($"{name} is now dead.");
            Console.WriteLine("You are a terrible person.");

            

            //return; //maybe instead of return here... the loop will end above and you can just close out?
        }
    }
}
