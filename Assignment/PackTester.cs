using System;
using System.Collections.Generic;

namespace Assignment
{
    public class Pack
    {
        private List<InventoryItem> _items;
        private int _maxCount;
        private double _maxWeight;
        private double _maxVolume;

        public Pack(int maxCount, double maxWeight, double maxVolume)
        {
            _items = new List<InventoryItem>();
            _maxCount = maxCount;
            _maxWeight = maxWeight;
            _maxVolume = maxVolume;
        }

        public bool Add(InventoryItem item)
        {
            if (_items.Count >= _maxCount || CalculateTotalWeight() + item.Weight > _maxWeight ||
                CalculateTotalVolume() + item.Volume > _maxVolume)
            {
                return false;
            }

            _items.Add(item);
            return true;
        }

        public override string ToString()
        {
            string packString = $"Pack: (Count: {_items.Count}, Weight: {CalculateTotalWeight()}, Volume: {CalculateTotalVolume()})\n";

            foreach (var item in _items)
            {
                packString += $"{item.Name}: Weight={item.Weight}, Volume={item.Volume}\n";
            }

            return packString;
        }

        private double CalculateTotalWeight()
        {
            double totalWeight = 0.0;
            foreach (var item in _items)
            {
                totalWeight += item.Weight;
            }
            return totalWeight;
        }

        private double CalculateTotalVolume()
        {
            double totalVolume = 0.0;
            foreach (var item in _items)
            {
                totalVolume += item.Volume;
            }
            return totalVolume;
        }
    }

    static class PackTester
    {
        public static void AddEquipment(Pack pack)
        {
            bool addMoreItems = true;
            do
            {
                Console.WriteLine(pack); // See output image for what this should display

                Console.WriteLine("What do you want to add?");
                Console.WriteLine("1 - Arrow");
                Console.WriteLine("2 - Bow");
                Console.WriteLine("3 - Rope");
                Console.WriteLine("4 - Water");
                Console.WriteLine("5 - Food");
                Console.WriteLine("6 - Sword");
                Console.WriteLine("7 - Gather your pack and venture forth");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    InventoryItem newItem = choice switch
                    {
                        1 => new Arrow("Arrow", 0.1, 0.2),
                        2 => new Bow("Bow", 1.5, 3.0),
                        3 => new Rope("Rope", 0.5, 1.0),
                        4 => new Water("Water", 0.5, 1.0),
                        5 => new Food("Food", 0.3, 0.5),
                        6 => new Sword("Sword", 2.0, 5.0),
                        _ => throw new InvalidOperationException("Invalid choice")
                    };

                    if (!pack.Add(newItem))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Could not fit this item into the pack.");
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is an invalid selection.");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Venturing Forth!");
                    addMoreItems = false;
                }
                Console.ResetColor();
            } while (addMoreItems);
        }
    }
}
