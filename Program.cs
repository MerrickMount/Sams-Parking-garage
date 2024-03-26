using System.Threading.Tasks.Dataflow;

namespace Sams_Parking_garage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double parkingTime;
            double parkingCost;
            Console.WriteLine("Hello, please state the parking total time in minutes");
            while (!double.TryParse(Console.ReadLine(), out parkingTime))
            {
                Console.WriteLine("This is not valid input. Please enter an integer value: ");
            }
            parkingCost = 4;
            if (parkingTime < 60)
            {
                parkingCost += 2;
                Console.WriteLine($"Your parking cost is {parkingCost.ToString("C")}");
            }
            if (parkingTime <= 120 && parkingTime >= 60)
            {
                parkingCost += 4;
                Console.WriteLine($"Your parking cost is {parkingCost.ToString("C")}");
            }
            if (parkingTime <= 180 && parkingTime >= 120)
            {
                parkingCost += 6;
                Console.WriteLine($"Your parking cost is {parkingCost.ToString("C")}");
            }
            if (parkingTime <= 240 && parkingTime >= 180)
            {
                parkingCost += 8;
                Console.WriteLine($"Your parking cost is {parkingCost.ToString("C")}");
            }
            if (parkingTime <= 300 && parkingTime >= 240)
            {
                parkingCost += 10;
                Console.WriteLine($"Your parking cost is {parkingCost.ToString("C")}");
            }
            if (parkingTime <= 360 && parkingTime >= 300)
            {
                parkingCost += 12;
                Console.WriteLine($"Your parking cost is {parkingCost.ToString("C")}");
            }
            if (parkingTime <= 420 && parkingTime >= 360)
            {
                parkingCost += 14;
                Console.WriteLine($"Your parking cost is {parkingCost.ToString("C")}");
            }
            if (parkingTime <= 480 && parkingTime >= 420)
            {
                parkingCost += 16;
                Console.WriteLine($"Your parking cost is {parkingCost.ToString("C")}");
            }
            if (parkingTime > 480)
            {
                Console.WriteLine("this is not an applicable time");
            }
        }
    }
}