using System;

namespace EpamAutoPark
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //CAR INFORMATION
            Engine carEngine = new Engine(800, 4.5, "SportCar", "AS888SS");
            Сhassis carChassis = new Сhassis(4, "CH11", 2000);
            Transmission carTransmission = new Transmission("Manual", 6, "AUDI");

            Console.WriteLine("Car INFO:\n");
            carEngine.PrintEngine();
            carChassis.PrintСhassis();
            carTransmission.PrintTransmission();

            //LORRY INFORMATION
            Engine lorryEngine = new Engine(1750, 14, "VolvoTruck", "99TR99");
            Сhassis lorryChassis = new Сhassis(6, "6RowRide", 17700.5);
            Transmission lorryTransmission = new Transmission("Manual", 4, "Volvo");
            
            Console.WriteLine("\nLorry INFO:\n");
            lorryEngine.PrintEngine();
            lorryChassis.PrintСhassis();
            lorryTransmission.PrintTransmission();

            //BUS INFORMATION
            Engine busEngine = new Engine(950, 9, "SchoolBus", "B*66");
            Сhassis busChassis = new Сhassis(6, "BusS*", 8808.8);
            Transmission busTransmission = new Transmission("AUTO", 6, "MAN");

            Console.WriteLine("\nBus INFO:\n");
            busEngine.PrintEngine();
            busChassis.PrintСhassis();
            busTransmission.PrintTransmission();

            //SCOOTER INFORMATION
            Engine scooterEngine = new Engine(150, 0.5, "Small_0.5", "ScooterEngine");
            Сhassis scooterChassis = new Сhassis(2, "Sc_low*", 500);
            Transmission scooterTransmission = new Transmission("AUTO", 5, "Scimanno");

            Console.WriteLine("\nScooter INFO:\n");
            scooterEngine.PrintEngine();
            scooterChassis.PrintСhassis();
            scooterTransmission.PrintTransmission();

            Console.ReadLine();

        }
    }
}
