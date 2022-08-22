using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public bool CanFly { get; set; }       

        public bool IsSmall { get; set; }

        public bool HasFeathers { get; set; } = true;
        public double WingSpan { get; set; }
    }
}
