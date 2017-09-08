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
        private int numberOfTeeth;
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

        public int NumberOfTeeth
        {
            get { return this.numberOfTeeth; }
            set { this.numberOfTeeth = value; }
        }

        public string Sound
        {
            get { return this.sound; }
            set { this.sound = value; }
        }


        //constructors

        Pet()
        {
            this.breed = breed;
            this.isHungry = isHungry;
            this.isVegetarian = isVegetarian;
            this.numberOfTeeth = numberOfTeeth;
            this.dangerLevel = dangerLevel;
            this.sound = sound;
        }


        //methods
    
        //intro. 
        //hungry, danger, teeth all in one
        //or hungry and veggie, danger and teeth
        //sound, maybe when pet or something
    }
}
