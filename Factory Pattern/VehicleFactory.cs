using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    static class VehicleFactory
    {
        

        public static IVehicle CreateVehicle(int numberOfTires)
        {

            if (numberOfTires == 2)
            {
                return new Motorcycle();
            }
            else
            {
                return new Car();
            }
            //switch (userInput.ToLower())
            //{
            //    case "car":
            //        return new Car() {Color = "Blue", IsDriveable = true };
            //    default: 
            //        return new Motorcycle() { Color = "Red", HasHandBreak = true };
                
            //}
        }
    }
}
