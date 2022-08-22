using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            Bird falcon = new Bird()
            {
                  Name = "Falcon",
                  CanFly = true,
                  IsSmall = false,
                  IsGoodPet = false,
                  EatsMeat = true,
                  Legs = 2,
                  LandAnimal = false,
            };
            Reptile croc = new Reptile()
            {
                Name = "Crocodile",
                HasScales = true,
                HasShell = false,
                Legs = 4,
                IsGoodPet = true,
                EatsMeat = true,
                LandAnimal = true,
            };

            var animalList = new List<Animal>() { falcon, croc };
            foreach (var item in animalList)
            {

                string goodPet;
                if (item.IsGoodPet)
                {
                    goodPet = "Yes";
                }
                else 
                {
                     goodPet = "NO!!!";
                }
                string landAnimal;
                if (item.LandAnimal)
                {
                   landAnimal = "Yes";
                }
                else
                {
                    landAnimal = "No";
                }
                Console.WriteLine($"Name:{item.Name}");
                Console.WriteLine($"Does it make a good pet? - {goodPet}");
                Console.WriteLine($"How many legs does it have? - {item.Legs}");
                Console.WriteLine($"Is it a land animal? - {landAnimal}");
                Console.WriteLine();
            }



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
