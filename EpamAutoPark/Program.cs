using System;
using System.Collections.Generic;
using System.Linq;

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
            Engine carEngine = new Engine() { power = 800, volume = 4.5, type = "SportCar", numberEngine = "AS888SS" };
            Сhassis carChassis = new Сhassis(4, "CH18951", 2000);
            Transmission carTransmission = new Transmission("Manual", 6, "AUDI");

            Console.WriteLine("Car INFO:\n");
            carEngine.PrintEngine();
            carChassis.PrintСhassis();
            carTransmission.PrintTransmission();

            Console.WriteLine("\nEngine List:\n");

            var theEngines = new List<Engine>()
                {
                    new Engine() { power = 80, volume = 1.0,  type = "Car_Golf", numberEngine = "Car_010"},
                    new Engine() { power = 90, volume = 1.2,  type = "Car_Civic", numberEngine = "Car_012"},
                    new Engine() { power = 120, volume = 1.5, type = "Car_Accord", numberEngine = "Car_015"},
                    new Engine() { power = 180, volume = 2.0, type = "Car_Acura", numberEngine = "Car_020"},
                    new Engine() { power = 400, volume = 4.0, type = "Car_Jeep", numberEngine = "Car_040"},

                    new Engine() { power = 500, volume = 6,   type = "Lorry_Kamaz", numberEngine = "Lorry_060"},
                    new Engine() { power = 590, volume = 6.2, type = "Lorry_Man", numberEngine = "Lorry_062"},
                    new Engine() { power = 640, volume = 6.4, type = "Lorry_Mersedes", numberEngine = "Lorry_064"},
                    new Engine() { power = 710, volume = 6.8, type = "Lorry_Renaught", numberEngine = "Lorry_068"},
                    new Engine() { power = 800, volume = 7,   type = "Lorry_Volvo", numberEngine = "Lorry_070"},
                    
                    new Engine() { power = 520, volume = 6.4, type = "Bus_Liaz", numberEngine = "Bus_090"},
                    new Engine() { power = 575, volume = 9, type = "Bus_Scania", numberEngine = "Bus_090"},
                    new Engine() { power = 615, volume = 9, type = "Bus_Man", numberEngine = "Bus_090"},
                    new Engine() { power = 770, volume = 9, type = "Bus_Volvo", numberEngine = "Bus_090"},
                    new Engine() { power = 910, volume = 9, type = "Bus_Mersedes", numberEngine = "Bus_090"},

                    new Engine() { power = 700, volume = 9, type = "Scooter_Urban", numberEngine = "Scooter_090"},
                    new Engine() { power = 700, volume = 9, type = "Scooter_Xiaomi", numberEngine = "Scooter_090"},
                    new Engine() { power = 700, volume = 9, type = "Scooter_Racer", numberEngine = "Scooter_090"},
                    new Engine() { power = 700, volume = 9, type = "Scooter_Yamaha", numberEngine = "Scooter_090"},
                    new Engine() { power = 700, volume = 9, type = "Scooter_Honda", numberEngine = "Scooter_090"}
                };

            foreach (Engine theEngine in theEngines)
            {
                theEngine.PrintEngine();
            }



            //// LORRY information
            //Engine lorryEngine = new Engine(990, 14, "VolvoTruck", "99TR99");
            //Сhassis lorryChassis = new Сhassis(6, "6RowRide", 17700.5);
            //Transmission lorryTransmission = new Transmission("Manual", 4, "Volvo");

            //Console.WriteLine("\nLorry INFO:\n");
            //lorryEngine.PrintEngine();
            //lorryChassis.PrintСhassis();
            //lorryTransmission.PrintTransmission();

            //// BUS information
            //Engine busEngine = new Engine(750, 9, "SchoolBus", "B576");
            //Сhassis busChassis = new Сhassis(6, "BusS*", 8808.8);
            //Transmission busTransmission = new Transmission("AUTO", 6, "MAN");

            //Console.WriteLine("\nBus INFO:\n");
            //busEngine.PrintEngine();
            //busChassis.PrintСhassis();
            //busTransmission.PrintTransmission();

            //// SCOOTER information
            //Engine scooterEngine = new Engine(150, 0.5, "Small_0.5", "ScoEng66");
            //Сhassis scooterChassis = new Сhassis(2, "Sc_jump", 500);
            //Transmission scooterTransmission = new Transmission("AUTO", 5, "Scimanno");

            //Console.WriteLine("\nScooter INFO:\n");
            //scooterEngine.PrintEngine();
            //scooterChassis.PrintСhassis();
            //scooterTransmission.PrintTransmission();

            Console.ReadLine(); // Frendly exit
        }
       
    }
}
