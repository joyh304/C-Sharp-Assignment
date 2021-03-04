using System;

namespace transport
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus newBus = new Bus();
            newBus.newBus();

            Truck newTruck = new Truck();
            newTruck.newTruck();
        }
    }
}
