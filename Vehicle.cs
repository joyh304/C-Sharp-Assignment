using System;

namespace transport
{
    class Vehicle
    {
        public string Name,Color;
        public int Weight;
        public Vehicle()
        {

        }
        public Vehicle(String name, string color)
        {
            this.Name = name;
            this.Color = color;
        }
        public Vehicle(String name, string color, int weight)
        {
            this.Name = name;
            this.Color = color;
            this.Weight = weight;
        }
    }
}