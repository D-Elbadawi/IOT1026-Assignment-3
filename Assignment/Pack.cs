using System;

namespace Assignment
{
    class Pack
    {
        private List<InventoryItem> _items; // Using List<> data structure instead of an array
        private int _maxCount;
        private float _maxVolume;
        private float _maxWeight;

        public Pack(int maxCount, float maxVolume, float maxWeight)
        {
            _items = new List<InventoryItem>();
            _maxCount = maxCount;
            _maxVolume = maxVolume;
            _maxWeight = maxWeight;
        }

        public bool Add(InventoryItem item)
        {
            if (_items.Count >= _maxCount || _items.Sum(i => i.Volume) + item.Volume > _maxVolume || _items.Sum(i => i.Weight) + item.Weight > _maxWeight)
                return false;

            _items.Add(item);
            return true;
        }

        public override string ToString()
        {
            string result = "Pack contents:\n";
            foreach (InventoryItem item in _items)
            {
                result += item.ToString() + "\n";
            }
            return result;
        }
    }

    class InventoryItem
    {
        public float Volume { get; set; }
        public float Weight { get; set; }
    }

    class Arrow : InventoryItem
    {
        public Arrow() : base()
        {
            Volume = 0.1f;
            Weight = 0.05f;
        }
    }

    class Bow : InventoryItem
    {
        public Bow() : base()
        {
            Volume = 1.0f;
            Weight = 1.5f;
        }
    }

    class Rope : InventoryItem
    {
        public Rope() : base()
        {
            Volume = 0.5f;
            Weight = 0.8f;
        }
    }

    class Water : InventoryItem
    {
        public Water() : base()
        {
            Volume = 2.0f;
            Weight = 2.5f;
        }
    }

    class Food : InventoryItem
    {
        public Food() : base()
        {
            Volume = 1.5f;
            Weight = 1.0f;
        }
    }

    class Sword : InventoryItem
    {
        public Sword() : base()
        {
            Volume = 3.0f;
            Weight = 4.0f;
        }
    }
}
