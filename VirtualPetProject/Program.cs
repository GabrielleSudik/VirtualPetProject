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
            Console.WriteLine("Here is your new pet.");
            Console.WriteLine("First things first, let's name it.");
            Console.WriteLine("What do you want to call your new pet?");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("OK, now what would you like to do with your pet? Choose from:");
            Console.WriteLine("   1.  Learn about your pet");
            Console.WriteLine("   1.  Feed your pet");
            Console.WriteLine("   2.  Walk your pet");
            Console.WriteLine("   4.  Play with your pet");
            Console.WriteLine("   5.  Send your pet to the farm.");
            int choice = int.Parse(Console.ReadLine());


        


        }

        static void ToTheFarm()
        {
            Console.WriteLine("\nYou do know that \"sending a pet to the farm\" means putting them to sleep, right?");
            Console.WriteLine("You are a terrible person.");
            Console.WriteLine("Your pet is now dead.");
            return;
        }
    }
}
