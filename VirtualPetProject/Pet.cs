using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProject
{
    class Pet
    {
        //fields

        private string breed;
        private bool isHungry;
        private bool isVegetarian;
        private int dangerLevel;
        private int happiness; 
        private string sound;

        //properties

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public bool IsVegetarian
        {
            get { return this.isVegetarian; }
            set { this.isVegetarian = value; }
        }

        public int DangerLevel
        {
            get { return this.dangerLevel; }
            set { this.dangerLevel = value; }
        }


            public int Happiness
        {
            get { return this.happiness; }
            set { this.happiness = value; }
        }

        public string Sound
        {
            get { return this.sound; }
            set { this.sound = value; }
        }


        //constructors

        public Pet() //default pet is tricerotops
        {
            this.breed = "Tricerotops";
            this.isVegetarian = true;
            this.dangerLevel = 6;
            this.happiness = 0;
            this.sound = "gentle rumble"; 
        }

        public Pet(string breed)  //can you use this to assign stats to one type, and the default to the other type?
        {
            this.breed = breed;
            this.isVegetarian = true;
            this.dangerLevel = 6;
            this.happiness = 0;
            this.sound = "gentle rumble";

            if (breed == "T Rex")
            {
                this.isVegetarian = false;
                this.dangerLevel = 10;
                this.sound = "RRRAAARRRGGGGHHHHH!!!";
            }
        }



        //methods

        //intro. 
        //a show stats method. maybe accept the name here.
        //hungry, danger, teeth all in one
        //or hungry and veggie, danger and teeth
        //sound, maybe when pet or something

            public void PetStatus(string name)
        {
            Console.WriteLine($"Here's how {name} is feeling:\n");
            string hungerStatus = "";

            if (dangerLevel >= 5)
            {
                hungerStatus = "  Your pet is very hungry.";
            }

            else if (dangerLevel >= 2 && dangerLevel <= 4)
            {
                hungerStatus = "  Your pet is a wee bit peckish.";
            }

            else
            {
                hungerStatus = "  Your pet is well fed.";
            }

            Console.WriteLine(hungerStatus);


            string walkStatus = "";

            if (dangerLevel > 1)
            {
                walkStatus = "  Your pet is too dangerous to take outside! It might eat something.";
            }

            else
            {
                walkStatus = "  Your pet is safe to take for a walk.";
            }

            Console.WriteLine(walkStatus);


            string happinessStatus = "";

            if (happiness >= 3)
            {
                happinessStatus = "  Your pet is very happy and loves you very much!";
            }

            else if (happiness == 1 || happiness == 2)
                {
                happinessStatus = "  Your pet would like more attention.";
            }

            else
            {
                happinessStatus = "  Your pet is unhappy, and needs some playtime.";
            }

            Console.WriteLine(happinessStatus);
            Console.WriteLine();

        }

    public void AboutPet(string breed)
        {
            if (breed == "T Rex")
            {
                Console.WriteLine("\nThe T Rex is an amazingly hostile beast!");
                Console.WriteLine("It's really rude and dangerous, so be careful about taking it outside.");
                Console.WriteLine("But its bloodlust can be sated with lots of beef.");
                Console.WriteLine("When happy, it will emit an agonizingly loud ROAR.");;
            }

            else
            {
                Console.WriteLine("The Tricerotops is slow and large, but relatively tame.");
                Console.WriteLine("Compared to many dinosaurs, it is only slightly dangerous.");
                Console.WriteLine("Keep it calm and sated with lots of bamboo.");
                Console.WriteLine("When happy, it will hum at a sub-sonic pitch.");
            }
        }


        public void FeedPet(string breed)
        {
            Console.WriteLine("\nDo you want to give your pet:");
            Console.WriteLine("  beef or bamboo?");
            string food = Console.ReadLine();

            Console.WriteLine();

            if (isVegetarian == true)
            {
                if (food == "bamboo")
                {
                    dangerLevel -= 4;
                    Console.WriteLine("Your pet is less hungry and less dangerous.");
                }

                else
                {
                    dangerLevel += 2;
                    Console.WriteLine("Your pet is upset at the thought of eating flesh.");
                    Console.WriteLine(  "It is now hungry AND more dangerous!");
                }
            }

            else
            {
                if (food == "beef")
                {
                    dangerLevel -= 4;
                    Console.WriteLine("Your pet is less hungry and less dangerous.");
                }

                else
                {
                    dangerLevel += 2;
                    Console.WriteLine("\nYour pet hates salad! It is now hungry AND more dangerous!");
                }
            }
            
        }

        public void WalkPet()
        {
            if (dangerLevel >= 1)
            {
                Console.WriteLine("\nYour pet is hungry, and too dangerous to take outside.");
                Console.WriteLine("Hit return to see the menu again (hint: Feed your pet more).");
            }
            //    string answer = Console.ReadLine();

            //    if (answer == "yes")
            //    {
            //        return; //not sure if return is the right word??
            //    }

            //    else 
            //            {
            //        Console.WriteLine("A hungry dinosaur is a dangerous dinosaur.");
            //        Console.WriteLine("You've been eaten by your own pet.");
            //        Console.WriteLine("Next time, just feed it, ok?");

            //        return;
            //    }
            //}

            else
            {
                Console.WriteLine("\nYour pet is satisfied and calm. You walk it without incident.");
            }
        }

        public void PetPet()
        {
            Console.WriteLine("\nWhich do you want to do to play with your pet:");
            Console.WriteLine("   cuddle, chase or tease?");
            string playChoice = Console.ReadLine();

            if (playChoice == "cuddle")
            {
                happiness += 3;
                Console.WriteLine("Your pet loves you and is much happier!");
            }

            else if (playChoice == "chase")
            {
                happiness += 2;
                Console.WriteLine("Your pet got some exercise and is somewhat happier.");
            }

            else 
                    {
                happiness--;
                Console.WriteLine("Your pet is less happy.");
            }

            if (happiness >= 3)
            {
                Console.WriteLine($"Your pet lets out a joyful {sound}.");
            }

            else if (happiness >= 0 && happiness <= 2)
            {
                Console.WriteLine("Your pet could use some more play time.");
            }

            else
            {
                Console.WriteLine("Your pet is angry. Better play with it a lot more!");
            }
        }
    }
}
