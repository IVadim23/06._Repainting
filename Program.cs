using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add nylon quantity:");
            int nylonQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Add nylon paint:");
            double paintQuantity = double.Parse(Console.ReadLine());
            Console.WriteLine("Add litters quantity:");
            int thinnerLitters = int.Parse(Console.ReadLine());
            Console.WriteLine("Add nunbers of working hours:");
            int workingHours = int.Parse(Console.ReadLine());

            paintQuantity = paintQuantity + paintQuantity * 0.10;
            //paintQuantity += paintQuantity * 0.10;
            nylonQuantity = nylonQuantity + 2;
            //nylonQuantity += 2;

            double nylonPrice = nylonQuantity * 1.50;
            double paintPrice = paintQuantity * 14.50;
            double thinnerPrice = thinnerLitters * 5.00;

            double materialsSum = nylonPrice + paintPrice + thinnerPrice + 0.40;
            double pricePerHour = materialsSum * 0.30;

            double workersSum = workingHours * pricePerHour;
            double totalSum = materialsSum + workersSum;
            Console.WriteLine("Total sum is:\n {0;f2}",totalSum);
        }
    }
}
