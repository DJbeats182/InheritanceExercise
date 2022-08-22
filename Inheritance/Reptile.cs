using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool HasShell { get; set; }
        public bool IsLarge { get; set; }

        public bool HasScales { get; set; }

        public bool Crawls { get; set; }
       
    }
}
