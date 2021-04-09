using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class Car : IVehicle
    {
        public string Color { get; set; }
        public bool IsDriveable { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Sorry can't text, I'm driving {Color} car");

        }
    }
}
