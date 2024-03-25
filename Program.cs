namespace Sams_Parking_garage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double parkingTime;
            double parkingCost;
            Console.WriteLine("Hello, please state the parking total time");
            parkingTime = int.Parse(Console.ReadLine());
            parkingTime = parkingTime / 60;
            parkingCost = 4 + (2 * (0.5 +(Math.Round(parkingTime,MidpointRounding.AwayFromZero))));
            Console.WriteLine($"{parkingCost}, {parkingTime}"); 
            Console.WriteLine(Math.Round(parkingTime, MidpointRounding.AwayFromZero));
            if (parkingTime < 1)
            {
                Console.WriteLine($"Your parking cost is {parkingCost}");
            }
            if (parkingTime <= 2 && parkingTime >= 1)
            {
                Console.WriteLine($"Your parking cost is {parkingCost}");
            }
            if (parkingTime <= 3 && parkingTime >= 2)
            {
                Console.WriteLine($"Your parking cost is {parkingCost}");
            }
            if (parkingTime <= 4 && parkingTime >= 3)
            {
                Console.WriteLine($"Your parking cost is {parkingCost}");
            }
            if (parkingTime <= 5 && parkingTime >= 4)
            {
                Console.WriteLine($"Your parking cost is {parkingCost}");
            }
            if (parkingTime <= 6 && parkingTime >= 5)
            {
                Console.WriteLine($"Your parking cost is {parkingCost}");
            }
            if (parkingTime <= 7 && parkingTime >= 6)
            {
                Console.WriteLine($"Your parking cost is {parkingCost}");
            }
            if (parkingTime <= 8 && parkingTime >= 7)
            {
                Console.WriteLine($"Your parking cost is {parkingCost}");
            }
            if (parkingTime > 8)
            {
                Console.WriteLine("this is not an applicable time");
            }
        }
    }
}