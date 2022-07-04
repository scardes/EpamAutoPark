using System;

/// <summary>
/// Car park management program. Output is information about all vehicles
/// </summary>
namespace EpamAutoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            // CAR information
            Engine carEngine = new Engine(800, 4.5, "SportCar", "AS888SS");
            Сhassis carChassis = new Сhassis(4, "CH18951", 2000);
            Transmission carTransmission = new Transmission("Manual", 6, "AUDI");

            Console.WriteLine("Car INFO:\n");
            carEngine.PrintEngine();
            carChassis.PrintСhassis();
            carTransmission.PrintTransmission();

            // LORRY information
            Engine lorryEngine = new Engine(990, 14, "VolvoTruck", "99TR99");
            Сhassis lorryChassis = new Сhassis(6, "6RowRide", 17700.5);
            Transmission lorryTransmission = new Transmission("Manual", 4, "Volvo");
            
            Console.WriteLine("\nLorry INFO:\n");
            lorryEngine.PrintEngine();
            lorryChassis.PrintСhassis();
            lorryTransmission.PrintTransmission();

            // BUS information
            Engine busEngine = new Engine(750, 9, "SchoolBus", "B576");
            Сhassis busChassis = new Сhassis(6, "BusS*", 8808.8);
            Transmission busTransmission = new Transmission("AUTO", 6, "MAN");

            Console.WriteLine("\nBus INFO:\n");
            busEngine.PrintEngine();
            busChassis.PrintСhassis();
            busTransmission.PrintTransmission();

            // SCOOTER information
            Engine scooterEngine = new Engine(150, 0.5, "Small_0.5", "ScoEng66");
            Сhassis scooterChassis = new Сhassis(2, "Sc_jump", 500);
            Transmission scooterTransmission = new Transmission("AUTO", 5, "Scimanno");

            Console.WriteLine("\nScooter INFO:\n");
            scooterEngine.PrintEngine();
            scooterChassis.PrintСhassis();
            scooterTransmission.PrintTransmission();

            Console.ReadLine(); // Frendly exit
        }
    }
}
