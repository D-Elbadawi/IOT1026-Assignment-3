using System;

namespace Assignment
{
    static class Program
    {
        static void Main()
        {
            const int PackMaxItems = 10;
            const float PackMaxVolume = 20;
            const float PackMaxWeight = 30;
            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);
            PackTester.AddEquipment(pack);
        }
    }
}
