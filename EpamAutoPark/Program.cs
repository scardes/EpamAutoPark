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
            var theEngines = new List<Engine>()
                {
                    new Engine() { power = 80,  volume = 1.1, type = "Car_VW Golf 4",    numberEngine = "Car_015"},
                    new Engine() { power = 110, volume = 1.3, type = "Car_Honda Civic",  numberEngine = "Car_018"},
                    new Engine() { power = 120, volume = 1.5, type = "Car_Honda Accord", numberEngine = "Car_015"},
                    new Engine() { power = 180, volume = 2.0, type = "Car_Acura RSX",    numberEngine = "Car_020"},
                    new Engine() { power = 400, volume = 4.0, type = "Car_Jeep Liberty", numberEngine = "Car_040"},

                    new Engine() { power = 500, volume = 6,   type = "Lorry_Kamaz",      numberEngine = "Lorry_060"},
                    new Engine() { power = 590, volume = 6.2, type = "Lorry_Man",        numberEngine = "Lorry_062"},
                    new Engine() { power = 640, volume = 6.4, type = "Lorry_Mersedes",   numberEngine = "Lorry_064"},
                    new Engine() { power = 710, volume = 6.8, type = "Lorry_Renaught",   numberEngine = "Lorry_068"},
                    new Engine() { power = 800, volume = 7,   type = "Lorry_Volvo",      numberEngine = "Lorry_070"},
                    
                    new Engine() { power = 520, volume = 6.4, type = "Bus_Liaz",     numberEngine = "Bus_064"},
                    new Engine() { power = 575, volume = 6.9, type = "Bus_Scania",   numberEngine = "Bus_069"},
                    new Engine() { power = 615, volume = 7.2, type = "Bus_Man",      numberEngine = "Bus_072"},
                    new Engine() { power = 770, volume = 7.4, type = "Bus_Volvo",    numberEngine = "Bus_074"},
                    new Engine() { power = 910, volume = 8,   type = "Bus_Mersedes", numberEngine = "Bus_080"},

                    new Engine() { power = 38,  volume = 0.3, type = "Scooter_Urban",  numberEngine = "Scooter_003"},
                    new Engine() { power = 43,  volume = 0.3, type = "Scooter_Xiaomi", numberEngine = "Scooter_103"},
                    new Engine() { power = 70,  volume = 0.7, type = "Scooter_Racer",  numberEngine = "Scooter_007"},
                    new Engine() { power = 100, volume = 1.0, type = "Scooter_Yamaha", numberEngine = "Scooter_010"},
                    new Engine() { power = 140, volume = 1.1, type = "Scooter_Honda",  numberEngine = "Scooter_011"}
                };

            var theChassises = new List<Сhassis>()
                {
                    new Сhassis() { type = "Car_VW Golf 4",    wheel = 4, numberChassis = "CRWG_448", load = 2400},
                    new Сhassis() { type = "Car_Honda Civic",  wheel = 4, numberChassis = "CRHC_951", load = 2250},
                    new Сhassis() { type = "Car_Honda Accord", wheel = 4, numberChassis = "CRHC_772", load = 3000},
                    new Сhassis() { type = "Car_Acura RSX",    wheel = 4, numberChassis = "CRHC_111", load = 3060},
                    new Сhassis() { type = "Car_Jeep Liberty", wheel = 4, numberChassis = "CRJL_1RR", load = 4000},

                    new Сhassis() { type = "Lorry_Kamaz",    wheel = 6, numberChassis = "LK_655", load = 5400},
                    new Сhassis() { type = "Lorry_Man",      wheel = 6, numberChassis = "LM_777", load = 6000},
                    new Сhassis() { type = "Lorry_Mersedes", wheel = 6, numberChassis = "LQ_88M", load = 7000},
                    new Сhassis() { type = "Lorry_Renaught", wheel = 6, numberChassis = "LR_515", load = 7560},
                    new Сhassis() { type = "Lorry_Volvo",    wheel = 8, numberChassis = "LV_155", load = 11000},

                    new Сhassis() { type = "Bus_Liaz",      wheel = 4, numberChassis = "BSL_03K0", load = 4400},
                    new Сhassis() { type = "Bus_Scania",    wheel = 4, numberChassis = "BSS_0LK8", load = 4250},
                    new Сhassis() { type = "Bus_Man",       wheel = 6, numberChassis = "BSM_0RK1", load = 6600},
                    new Сhassis() { type = "Bus_Volvo",     wheel = 6, numberChassis = "BSV_0FK9", load = 7960},
                    new Сhassis() { type = "Bus_Mersedes",  wheel = 4, numberChassis = "BSM_0CK2", load = 8500},

                    new Сhassis() { type = "Scooter_Urban",  wheel = 2, numberChassis = "SC00U11", load = 1400},
                    new Сhassis() { type = "Scooter_Xiaomi", wheel = 2, numberChassis = "SC00X24", load = 1250},
                    new Сhassis() { type = "Scooter_Racer",  wheel = 2, numberChassis = "SC00R15", load = 1500},
                    new Сhassis() { type = "Scooter_Yamaha", wheel = 2, numberChassis = "SC00Y26", load = 2060},
                    new Сhassis() { type = "Scooter_Honda",  wheel = 2, numberChassis = "SC00H23", load = 2300}
                };

            var theTransmissions = new List<Transmission>()
                {
                    new Transmission() {type = "Manual", gear = 5, manufacturer = "Car_VW Golf 4"},
                    new Transmission() {type = "Manual", gear = 5, manufacturer = "Car_Honda Civic"},
                    new Transmission() {type = "Auto",   gear = 6, manufacturer = "Car_Honda Accord"},
                    new Transmission() {type = "Manual", gear = 6, manufacturer = "Car_Acura RSX"},
                    new Transmission() {type = "Auto",   gear = 5, manufacturer = "Car_Jeep Liberty"},

                    new Transmission() {type = "Manual", gear = 6, manufacturer = "Lorry_Kamaz"},
                    new Transmission() {type = "Auto",   gear = 7, manufacturer = "Lorry_Man"},
                    new Transmission() {type = "Auto",   gear = 7, manufacturer = "Lorry_Mersedes"},
                    new Transmission() {type = "Manual", gear = 6, manufacturer = "Lorry_Renaught"},
                    new Transmission() {type = "Manual", gear = 5, manufacturer = "Lorry_Volvo"},

                    new Transmission() {type = "Manual", gear = 5, manufacturer = "Bus_Liaz"},
                    new Transmission() {type = "Manual", gear = 5, manufacturer = "Bus_Scania"},
                    new Transmission() {type = "Auto",   gear = 6, manufacturer = "Bus_Man"},
                    new Transmission() {type = "Manual", gear = 6, manufacturer = "Bus_Volvo"},
                    new Transmission() {type = "Auto",   gear = 5,  manufacturer = "Bus_Mersedes"},

                    new Transmission() {type = "Auto",   gear = 1, manufacturer = "Scooter_Urban"},
                    new Transmission() {type = "Auto",   gear = 1, manufacturer = "Scooter_Xiaomi"},
                    new Transmission() {type = "Auto",   gear = 4, manufacturer = "Scooter_Racer"},
                    new Transmission() {type = "Auto",   gear = 2, manufacturer = "Scooter_Yamaha"},
                    new Transmission() {type = "Auto",   gear = 3, manufacturer = "Scooter_Honda"}

                };

            var theAutos = new List<Auto>()
                {
                    new Auto() {type = "Car_VW Golf 4",    year = 2005},
                    new Auto() {type = "Car_Honda Civic",  year = 2010},
                    new Auto() {type = "Car_Honda Accord", year = 2021},
                    new Auto() {type = "Car_Acura RSX",    year = 2020},
                    new Auto() {type = "Car_Jeep Liberty", year = 1995},
                    
                    new Auto() {type = "Lorry_Kamaz",    year = 1997},
                    new Auto() {type = "Lorry_Man",      year = 2019},
                    new Auto() {type = "Lorry_Mersedes", year = 2015},
                    new Auto() {type = "Lorry_Renaught", year = 2011},
                    new Auto() {type = "Lorry_Volvo",    year = 2022},

                    new Auto() {type = "Bus_Liaz",     year = 1991},
                    new Auto() {type = "Bus_Scania",   year = 1998},
                    new Auto() {type = "Bus_Man",      year = 2009},
                    new Auto() {type = "Bus_Volvo",    year = 2021},
                    new Auto() {type = "Bus_Mersedes", year = 2022},

                    new Auto() {type = "Scooter_Urban",  year = 2021},
                    new Auto() {type = "Scooter_Xiaomi", year = 2022},
                    new Auto() {type = "Scooter_Racer",  year = 2022},
                    new Auto() {type = "Scooter_Yamaha", year = 2020},
                    new Auto() {type = "Scooter_Honda",  year = 2021}

                };

            Console.WriteLine("*** List of all Vehicles ***\n");

            var autos = from auto in theAutos
                        join engine in theEngines on auto.type equals engine.type
                        join chassises in theChassises on auto.type equals chassises.type
                        join transmission in theTransmissions on auto.type equals transmission.manufacturer

                        select new {Type = auto.type, Year = auto.year, 
                            Power = engine.power, Volume = engine.volume, EngineNumber = engine.numberEngine,
                            Wheel = chassises.wheel, Number = chassises.numberChassis, Load = chassises.load, 
                            TrasnmissionType = transmission.type, Gear = transmission.gear, Manufacturer = transmission.manufacturer };

            foreach (var auto in autos)
            {
                Console.WriteLine($"  Vehicle Type: {auto.Type} - {auto.Year} year:" +
                    $"\nEngine  INFO:\t   *Power*: {auto.Power}\t\t *Volume*: {auto.Volume}\t\t *Serial Number*: {auto.EngineNumber}\t" +
                    $"\nСhassis INFO:\t   *Wheel*: {auto.Wheel}\t\t *Number*: {auto.Number}\t *Load*: {auto.Load}\t " +
                    $"\nTransmission INFO: *Type* : {auto.TrasnmissionType}\t *Have Gears*: {auto.Gear}\t *Manufacturer*: {auto.Manufacturer}\t \n");
            }

            Console.WriteLine("\n***1. Vehicles(full information) with Engine Volume more than 1.5 litres ***\n\n");

            var bigEngine = from se in autos
                              where se.Volume > 1.5
                              select se;

            foreach (var auto in bigEngine)
            {
                Console.WriteLine($"  Vehicle Type: {auto.Type} - {auto.Year} year:" +
                    $"\nEngine  INFO:\t   *Power*: {auto.Power}\t\t *Volume*: {auto.Volume}\t\t *Serial Number*: {auto.EngineNumber}\t" +
                    $"\nСhassis INFO:\t   *Wheel*: {auto.Wheel}\t\t *Number*: {auto.Number}\t *Load*: {auto.Load}\t " +
                    $"\nTransmission INFO: *Type* : {auto.TrasnmissionType}\t *Have Gears*: {auto.Gear}\t *Manufacturer*: {auto.Manufacturer}\t \n");
            }

            Console.WriteLine("\n***2. Engine Information of lorries and buses ***\n\n");

            var enginesLorryBus = from elb in autos
                                  where elb.Type.Contains("Lorry") || elb.Type.Contains("Bus")
                                  select elb;

            foreach (var auto in enginesLorryBus)
            {
                Console.WriteLine($"  Vehicle Type: {auto.Type} - {auto.Year} year:" +
                    $"\nEngine  INFO:\t   *Power*: {auto.Power}\t\t *Volume*: {auto.Volume}\t\t *Serial Number*: {auto.EngineNumber}\t\n");
            }

            Console.WriteLine("\n***3. Vehicles(full information) with group by TrasnmissionType ***\n\n");

            var transmissionSorter = from ts in autos
                                     orderby ts.TrasnmissionType
                                     select ts;

            foreach (var auto in transmissionSorter)
            {
                Console.WriteLine($"  Vehicle Type: {auto.Type} - {auto.Year} year \tAND *Trasnmission Type* : ***{auto.TrasnmissionType}***" +
                    $"\nEngine  INFO:\t   *Power*: {auto.Power}\t\t *Volume*: {auto.Volume}\t\t *Serial Number*: {auto.EngineNumber}\t" +
                    $"\nСhassis INFO:\t   *Wheel*: {auto.Wheel}\t\t *Number*: {auto.Number}\t *Load*: {auto.Load}\t " +
                    $"\nTransmission INFO: *Type* : {auto.TrasnmissionType}\t *Have Gears*: {auto.Gear}\t *Manufacturer*: {auto.Manufacturer}\t \n");
            }

            Console.WriteLine("Programm Exit");
            Console.ReadLine(); // Frendly exit
        }
    }
}
