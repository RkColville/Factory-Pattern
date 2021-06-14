using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class Car : IVehicle
    {
        public string Color { get; set; }
        public bool IsDriveable { get; set; }

        public Car()
        {

        }

        public void Drive()
        {
            Console.WriteLine($"I'm driving my {Color} car");

        }
    }
}
