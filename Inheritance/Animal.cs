using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public bool EatsMeat { get; set; }
        public int Legs { get; set; } = 4;

        public bool LandAnimal { get; set; }

        public bool IsGoodPet { get; set; }
        public string Name { get; set; }
    }
}
