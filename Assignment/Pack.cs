using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment
{
    public abstract class InventoryItem
    {
        public string Name { get; set; }
        public double Volume { get; set; }
        public double Weight { get; set; }
        //New Items
        public InventoryItem(string name, double volume, double weight)
        {
            Name = name;
            Volume = volume;
            Weight = weight;
        }
    }




    class Arrow : InventoryItem
    {
        public Arrow(string name, double volume, double weight) : base(name, volume, weight)
        {
        }
    }

    class Bow : InventoryItem
    {
        public Bow(string name, double volume, double weight) : base(name, volume, weight)
        {
        }
    }

    class Rope : InventoryItem
    {
        public Rope(string name, double volume, double weight) : base(name, volume, weight)
        {
        }
    }

    class Water : InventoryItem
    {
        public Water(string name, double volume, double weight) : base(name, volume, weight)
        {
        }
    }

    class Food : InventoryItem
    {
        public Food(string name, double volume, double weight) : base(name, volume, weight)
        {
        }
    }

    class Sword : InventoryItem
    {
        public Sword(string name, double volume, double weight) : base(name, volume, weight)
        {
        }
    }
}
