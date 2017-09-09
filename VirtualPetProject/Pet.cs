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
        private int maxDanger; //update this below
        private int happiness; //add this below
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

        //public int NumberOfTeeth
        //{
        //    get { return this.numberOfTeeth; }
        //    set { this.numberOfTeeth = value; }
        //}

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

        public Pet()
        {
            this.breed = "Tricerotops";
            this.isHungry = !isHungry;
            this.isVegetarian = true;
            //this.numberOfTeeth = numberOfTeeth;
            this.dangerLevel = 6;
            this.happiness = 0;
            this.sound = "** subsonic rumble **";  //update these
        }

        public Pet(string breed)  //can you use this to assign stats to one type, and the default to the other type?
        {
            this.breed = "Tyrannasaurus Rex";
            this.isHungry = isHungry;
            this.isVegetarian = !isVegetarian;
            //this.numberOfTeeth = 60;
            this.dangerLevel = 10;
            this.sound = "RRRRRRAAAAAAAARRRRRRRGGGGGHHHHHHHHHHHH!!!!!";
        }



        //methods

        //intro. 
        //a show stats method. maybe accept the name here.
        //hungry, danger, teeth all in one
        //or hungry and veggie, danger and teeth
        //sound, maybe when pet or something

    public void AboutPet(string breed)
        {
            if (breed == "T Rex")
            {
                Console.WriteLine("\nThe T Rex is an amazingly hostile beast!");
                Console.WriteLine("It's really rude and dangerous, so be careful about taking it outside.");
                Console.WriteLine("But its bloodlust can be sated with a tasty slab of beef.");
                Console.WriteLine("When cuddled, it will emit an agonizingly loud ROAR.");
                Console.WriteLine("A very exiting pet.");
            }

            else
            {
                Console.WriteLine("The Tricerotops is slow and large, but relatively tame.");
                Console.WriteLine("Compared to many dinosaurs, it is only slightly dangerous.");
                Console.WriteLine("When upset, it should be fed lots of bamboo.");
                Console.WriteLine("When cuddled, it will hum at a sub-sonic pitch.");
                Console.WriteLine("A gentle pet (for a dinosaur).");
            }
        }


        public void FeedPet(string breed)
        {
            Console.WriteLine("\nDo you want to give your pet:");
            Console.WriteLine("  beef or bamboo?");
            string food = Console.ReadLine();

            if (breed == "Tricerotops")
            {
                if (food == "bamboo")
                {
                    //consider a pet happiness increase?
                    dangerLevel -= 4;
                    Console.WriteLine("Your pet is happier and less dangerous.");
                }

                else
                {
                    dangerLevel += 2;
                    Console.WriteLine("Your pet is upset at the thought of eating flesh.");
                    Console.WriteLine(  "It is now angry and more dangerous!");
                }
            }

            else
            {
                if (food == "beef")
                {
                    //consider a pet happiness increase?
                    dangerLevel -= 4;
                    Console.WriteLine("Your pet is full and less dangerous.");
                }

                else
                {
                    dangerLevel += 2;
                    Console.WriteLine("\nYour pet hates salad! It is now angry and more dangerous!");
                }
            }
            
        }

        public void WalkPet()
        {
            if (dangerLevel <= 3)
            {
                Console.WriteLine("\nYour pet is hungry, and too dangerous to take outside.");
                Console.WriteLine("Hit return to see the menu again (hint: Feed your pet).");
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
