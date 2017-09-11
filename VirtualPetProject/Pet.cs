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

        public Pet(string breed)  //mostly same as default, but with if statement to set other variables
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

        public void PetStatus(string name)  //called in Main's loop each time. shows pet mood.
                                            //shows hunger level, safety for walking, general happiness
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
                happinessStatus = "  Your pet is unhappy. Better be nice to it.";
            }

            Console.WriteLine(happinessStatus);
            Console.WriteLine();
        }

    public void AboutPet(string breed) //when selected, shows unchanging info about chosen pet
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
                Console.WriteLine("\nThe Tricerotops is slow and large, but relatively tame.");
                Console.WriteLine("Compared to many dinosaurs, it is only slightly dangerous.");
                Console.WriteLine("Keep it calm and sated with lots of bamboo.");
                Console.WriteLine("When happy, it will hum at a sub-sonic pitch.");
            }
        }

        public void FeedPet(string breed)  //when chosen, options for feeding pet and change in danger level.
                                           //feeding pet wrong food will make it more upset
                                           //feeding it correct food will calm it
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
                    Console.WriteLine("Your pet hates salad! It is now hungry AND more dangerous!");
                }
            }
        }

        public void WalkPet() //when selected, lets user know if pet is safe to take for a walk.
        {
            Console.WriteLine();

            if (dangerLevel >= 1)
            {
                Console.WriteLine("Your pet is too dangerous to take outside. Try feeding it more.");
            }
            
            else
            {
                Console.WriteLine("Your pet is satisfied and calm. You walk it without incident.");
            }
        }

        public void PetPet()  //when selected, user plays with pet, increasing or decreasing happiness
                              //will print changes in mood of pet
        {
            Console.WriteLine("\nWhat do you want to do with your pet:");
            Console.WriteLine("   cuddle, chase or tease?");
            string playChoice = Console.ReadLine();

            Console.WriteLine();

            if (playChoice == "cuddle")
            {
                happiness += 3;
                Console.WriteLine("Your pet loves cuddles and is much happier!");
            }

            else if (playChoice == "chase")
            {
                happiness += 2;
                Console.WriteLine("Your pet got some exercise and is somewhat happier.");
            }

            else 
                    {
                happiness--;
                Console.WriteLine("Your pet does not like to be teased, and is less happy.");
            }

            if (happiness >= 3)
            {
                Console.WriteLine($"Your pet lets out a joyful {sound}.");
            }

            else if (happiness >= 0 && happiness <= 2)
            {
                Console.WriteLine("Your pet is content but would like more play time.");
            }

            else
            {
                Console.WriteLine("Your pet is angry. Better play with it a lot more!");
            }
        }
    }
}
