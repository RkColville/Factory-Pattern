using System;
using System.Collections.Generic;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            bool finished = true;
            string anotherVehicle;
            List<IVehicle> vehicles = new List<IVehicle>();

            while (finished == true)
            {
                Console.WriteLine("What type of vehicle do you want to make? Car or Motorcycle?");
                Console.WriteLine();
                Console.WriteLine($"Type 1 for: Car");
                Console.WriteLine($"Type 2 for: Motorcyle");
                Console.WriteLine();

                var userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                {
                    vehicles.Add(VehicleFactory.CreateVehicle(1));
                }
                else
                    vehicles.Add(VehicleFactory.CreateVehicle(2));

                for (int i = 0; i < vehicles.Count; i++)
                {
                    vehicles[i].Drive();
                }

                Console.WriteLine("Would you like to create another vehicle? Please answer 'yes' or 'no'");
                anotherVehicle = Console.ReadLine().ToLower();

                if (anotherVehicle == "yes")
                {

                }
                else
                {
                    Console.WriteLine("See you next time then!");
                    finished = false;
                }
                    
            }
        }
            
    
    }

}

