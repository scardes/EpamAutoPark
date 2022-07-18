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
            //Сhassis carChassis = new Сhassis() { wheel = 4, numberChassis = "CH18951", load = 2000 };
            //Transmission carTransmission = new Transmission() { type = "Manual", gear = 6, manufacturer = "AUDI" };

            //Console.WriteLine("Car INFO:\n");
            //carEngine.PrintEngine();
            //carChassis.PrintСhassis();
            //carTransmission.PrintTransmission();

            var theEngines = new List<Engine>()
                {
                    new Engine() { power = 80, volume = 1.5,  type = "Car_Golf", numberEngine = "Car_015"},
                    new Engine() { power = 110, volume = 1.8,  type = "Car_Civic", numberEngine = "Car_018"},
                    new Engine() { power = 120, volume = 1.5, type = "Car_Accord", numberEngine = "Car_015"},
                    new Engine() { power = 180, volume = 2.0, type = "Car_Acura", numberEngine = "Car_020"},
                    new Engine() { power = 400, volume = 4.0, type = "Car_Jeep", numberEngine = "Car_040"},

                    new Engine() { power = 500, volume = 6,   type = "Lorry_Kamaz", numberEngine = "Lorry_060"},
                    new Engine() { power = 590, volume = 6.2, type = "Lorry_Man", numberEngine = "Lorry_062"},
                    new Engine() { power = 640, volume = 6.4, type = "Lorry_Mersedes", numberEngine = "Lorry_064"},
                    new Engine() { power = 710, volume = 6.8, type = "Lorry_Renaught", numberEngine = "Lorry_068"},
                    new Engine() { power = 800, volume = 7,   type = "Lorry_Volvo", numberEngine = "Lorry_070"},
                    
                    new Engine() { power = 520, volume = 6.4, type = "Bus_Liaz", numberEngine = "Bus_064"},
                    new Engine() { power = 575, volume = 6.9, type = "Bus_Scania", numberEngine = "Bus_069"},
                    new Engine() { power = 615, volume = 7.2, type = "Bus_Man", numberEngine = "Bus_072"},
                    new Engine() { power = 770, volume = 7.4, type = "Bus_Volvo", numberEngine = "Bus_074"},
                    new Engine() { power = 910, volume = 8, type = "Bus_Mersedes", numberEngine = "Bus_080"},

                    new Engine() { power = 38, volume = 0.3, type = "Scooter_Urban", numberEngine = "Scooter_003"},
                    new Engine() { power = 43, volume = 0.3, type = "Scooter_Xiaomi", numberEngine = "Scooter_103"},
                    new Engine() { power = 70, volume = 0.7, type = "Scooter_Racer", numberEngine = "Scooter_007"},
                    new Engine() { power = 100, volume = 1.0, type = "Scooter_Yamaha", numberEngine = "Scooter_010"},
                    new Engine() { power = 140, volume = 1.1, type = "Scooter_Honda", numberEngine = "Scooter_011"}
                };

            var theChassises = new List<Сhassis>()
                {
                    new Сhassis() { wheel = 4, numberChassis = "CH_886", load = 2000},
                    new Сhassis() { wheel = 4, numberChassis = "CH18951", load = 2000},
                    new Сhassis() { wheel = 4, numberChassis = "CH18951", load = 2000},
                    new Сhassis() { wheel = 4, numberChassis = "CH18951", load = 2000},
                    new Сhassis() { wheel = 4, numberChassis = "CH18951", load = 2000}
                    
                };

            var theTransmissions = new List<Transmission>()
                {
                    new Transmission() {type = "Manual", gear = 6, manufacturer = "AUDI"},
                    new Transmission() {type = "Manual", gear = 6, manufacturer = "AUDI"},
                    new Transmission() {type = "Manual", gear = 6, manufacturer = "AUDI"},
                    new Transmission() {type = "Manual", gear = 6, manufacturer = "AUDI"},
                    new Transmission() {type = "Manual", gear = 6, manufacturer = "AUDI"}

                };

            var theAutos = new List<Auto>()
                {
                    new Auto() {type = "Car", model = "VW Golf 4", year = 1995},
                    new Auto() {type = "Car", model = "Honda Civic", year = 1995},
                    new Auto() {type = "Car", model = "Honda Accord", year = 1995},
                    new Auto() {type = "Car", model = "Acura RSX", year = 1995},
                    new Auto() {type = "Car", model = "Jeep Liberty", year = 1995}

                };


            Console.WriteLine(theEngines[0]);

            Console.WriteLine("\nEngine List:\n");

            foreach (Engine theEngine in theEngines)
            {
                theEngine.PrintEngine();
            }

            Console.WriteLine("\nСhassis List:\n");

            foreach (Сhassis theChassis in theChassises)
            {
                theChassis.PrintСhassis();
            }

            Console.WriteLine("\nTransmission List:\n");

            foreach (Transmission theTransmission in theTransmissions)
            {
                theTransmission.PrintTransmission();
            }

            Console.WriteLine("\nAUTO List:\n");

            foreach (Auto theAuto in theAutos)
            {
                theAuto.PrintAuto();
            }


            //// LORRY information
            //Сhassis lorryChassis = new Сhassis(6, "6RowRide", 17700.5);
            //Transmission lorryTransmission = new Transmission("Manual", 4, "Volvo");

            //Console.WriteLine("\nLorry INFO:\n");
            //lorryChassis.PrintСhassis();
            //lorryTransmission.PrintTransmission();

            //// BUS information
            //Сhassis busChassis = new Сhassis(6, "BusS*", 8808.8);
            //Transmission busTransmission = new Transmission("AUTO", 6, "MAN");

            //Console.WriteLine("\nBus INFO:\n");
            //busChassis.PrintСhassis();
            //busTransmission.PrintTransmission();

            //// SCOOTER information
            //Сhassis scooterChassis = new Сhassis(2, "Sc_jump", 500);
            //Transmission scooterTransmission = new Transmission("AUTO", 5, "Scimanno");

            //Console.WriteLine("\nScooter INFO:\n");
            //scooterChassis.PrintСhassis();
            //scooterTransmission.PrintTransmission();

            Console.ReadLine(); // Frendly exit
        }
    }
}
