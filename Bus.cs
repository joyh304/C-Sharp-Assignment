using System;

namespace transport
{
    class Bus : Vehicle
    {
        public void newBus()
        {
            Vehicle newVehicle = new Vehicle("marcedes", "Red");
            Vehicle newVehicle1 = new Vehicle("marcedes", "Red", 400);

            Console.WriteLine(newVehicle.Name + " " + newVehicle.Color);
            Console.WriteLine(newVehicle1.Name + " " + newVehicle1.Color + " " + newVehicle1.Weight);
        }
    }
}