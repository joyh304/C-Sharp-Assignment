using System;

namespace transport
{
    class Truck : Vehicle
    {
        public void newTruck()
        {
            Vehicle newVehicle = new Vehicle("AUdi", "Red");
            Vehicle newVehicle1 = new Vehicle("Audi", "Red", 400);

            Console.WriteLine(newVehicle.Name + " " + newVehicle.Color);
            Console.WriteLine(newVehicle1.Name + " " + newVehicle1.Color + " " + newVehicle1.Weight);
        }
    }
}