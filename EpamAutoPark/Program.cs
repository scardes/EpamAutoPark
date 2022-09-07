using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

/// <summary>
/// Car park management program. Output is information about all vehicles
/// </summary>
namespace EpamAutoPark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var theEngines = new List<Engine>();
            var theChassises = new List<Сhassis>();
            var theTransmissions = new List<Transmission>();
            var theAutos = new List<Auto>();

            //Exceptions (.NET) 1.InitializationException for Engine
            try
            {
                theEngines = new List<Engine>()
                {
                    new Engine() { Power = 80,  Volume = 1.1, Type = "Car_VW Golf 4",    NumberEngine = "Car_015"},
                    new Engine() { Power = 110, Volume = 1.3, Type = "Car_Honda Civic",  NumberEngine = "Car_018"},
                    new Engine() { Power = 120, Volume = 1.5, Type = "Car_Honda Accord", NumberEngine = "Car_015"},
                    new Engine() { Power = 180, Volume = 2.0, Type = "Car_Acura RSX",    NumberEngine = "Car_020"},
                    new Engine() { Power = 400, Volume = 4.0, Type = "Car_Jeep Liberty", NumberEngine = "Car_040"},
                    new Engine() { Power = 500, Volume = 6,   Type = "Lorry_Kamaz",      NumberEngine = "Lorry_060"},
                    new Engine() { Power = 590, Volume = 6.2, Type = "Lorry_Man",        NumberEngine = "Lorry_062"},
                    new Engine() { Power = 640, Volume = 6.4, Type = "Lorry_Mersedes",   NumberEngine = "Lorry_064"},
                    new Engine() { Power = 710, Volume = 6.8, Type = "Lorry_Renaught",   NumberEngine = "Lorry_068"},
                    new Engine() { Power = 800, Volume = 7,   Type = "Lorry_Volvo",      NumberEngine = "Lorry_070"},
                    new Engine() { Power = 520, Volume = 6.4, Type = "Bus_Liaz",     NumberEngine = "Bus_064"},
                    new Engine() { Power = 575, Volume = 6.9, Type = "Bus_Scania",   NumberEngine = "Bus_069"},
                    new Engine() { Power = 615, Volume = 7.2, Type = "Bus_Man",      NumberEngine = "Bus_072"},
                    new Engine() { Power = 770, Volume = 7.4, Type = "Bus_Volvo",    NumberEngine = "Bus_074"},
                    new Engine() { Power = 910, Volume = 8,   Type = "Bus_Mersedes", NumberEngine = "Bus_080"},
                    new Engine() { Power = 38,  Volume = 0.3, Type = "Scooter_Urban",  NumberEngine = "Scooter_003"},
                    new Engine() { Power = 43,  Volume = 0.3, Type = "Scooter_Xiaomi", NumberEngine = "Scooter_103"},
                    new Engine() { Power = 70,  Volume = 0.7, Type = "Scooter_Racer",  NumberEngine = "Scooter_007"},
                    new Engine() { Power = 100, Volume = 1.0, Type = "Scooter_Yamaha", NumberEngine = "Scooter_010"},
                    new Engine() { Power = 140, Volume = 1.1, Type = "Scooter_Honda",  NumberEngine = "Scooter_011"}
                };
            }
            catch
            {
                Console.WriteLine("InitializationException. Please correct  input Engine data and try again!");
            }

            //Exceptions (.NET) 1.InitializationException for Сhassis
            try
            {
                theChassises = new List<Сhassis>()
                {
                    new Сhassis() { Type = "Car_VW Golf 4",    Wheel = 4, NumberChassis = "CRWG_448", Load = 2400},
                    new Сhassis() { Type = "Car_Honda Civic",  Wheel = 4, NumberChassis = "CRHC_951", Load = 2250},
                    new Сhassis() { Type = "Car_Honda Accord", Wheel = 4, NumberChassis = "CRHC_772", Load = 3000},
                    new Сhassis() { Type = "Car_Acura RSX",    Wheel = 4, NumberChassis = "CRHC_111", Load = 3060},
                    new Сhassis() { Type = "Car_Jeep Liberty", Wheel = 4, NumberChassis = "CRJL_1RR", Load = 4000},
                    new Сhassis() { Type = "Lorry_Kamaz",    Wheel = 6, NumberChassis = "LK_655", Load = 5400},
                    new Сhassis() { Type = "Lorry_Man",      Wheel = 6, NumberChassis = "LM_777", Load = 6000},
                    new Сhassis() { Type = "Lorry_Mersedes", Wheel = 6, NumberChassis = "LQ_88M", Load = 7000},
                    new Сhassis() { Type = "Lorry_Renaught", Wheel = 6, NumberChassis = "LR_515", Load = 7560},
                    new Сhassis() { Type = "Lorry_Volvo",    Wheel = 8, NumberChassis = "LV_155", Load = 11000},
                    new Сhassis() { Type = "Bus_Liaz",      Wheel = 4, NumberChassis = "BSL_03K0", Load = 4400},
                    new Сhassis() { Type = "Bus_Scania",    Wheel = 4, NumberChassis = "BSS_0LK8", Load = 4250},
                    new Сhassis() { Type = "Bus_Man",       Wheel = 6, NumberChassis = "BSM_0RK1", Load = 6600},
                    new Сhassis() { Type = "Bus_Volvo",     Wheel = 6, NumberChassis = "BSV_0FK9", Load = 7960},
                    new Сhassis() { Type = "Bus_Mersedes",  Wheel = 4, NumberChassis = "BSM_0CK2", Load = 8500},
                    new Сhassis() { Type = "Scooter_Urban",  Wheel = 2, NumberChassis = "SC00U11", Load = 1400},
                    new Сhassis() { Type = "Scooter_Xiaomi", Wheel = 2, NumberChassis = "SC00X24", Load = 1250},
                    new Сhassis() { Type = "Scooter_Racer",  Wheel = 2, NumberChassis = "SC00R15", Load = 1500},
                    new Сhassis() { Type = "Scooter_Yamaha", Wheel = 2, NumberChassis = "SC00Y26", Load = 2060},
                    new Сhassis() { Type = "Scooter_Honda",  Wheel = 2, NumberChassis = "SC00H23", Load = 2300}
                };
            }
            catch
            {
                Console.WriteLine("InitializationException. Please correct input Сhassis data and try again!");
            }

            //Exceptions (.NET) 1.InitializationException for Transmission
            try
            {
                theTransmissions = new List<Transmission>()
                {
                    new Transmission() {Type = "Manual", Gear = 5, Manufacturer = "Car_VW Golf 4"},
                    new Transmission() {Type = "Manual", Gear = 5, Manufacturer = "Car_Honda Civic"},
                    new Transmission() {Type = "Auto",   Gear = 6, Manufacturer = "Car_Honda Accord"},
                    new Transmission() {Type = "Manual", Gear = 6, Manufacturer = "Car_Acura RSX"},
                    new Transmission() {Type = "Auto",   Gear = 5, Manufacturer = "Car_Jeep Liberty"},
                    new Transmission() {Type = "Manual", Gear = 6, Manufacturer = "Lorry_Kamaz"},
                    new Transmission() {Type = "Auto",   Gear = 7, Manufacturer = "Lorry_Man"},
                    new Transmission() {Type = "Auto",   Gear = 7, Manufacturer = "Lorry_Mersedes"},
                    new Transmission() {Type = "Manual", Gear = 6, Manufacturer = "Lorry_Renaught"},
                    new Transmission() {Type = "Manual", Gear = 5, Manufacturer = "Lorry_Volvo"},
                    new Transmission() {Type = "Manual", Gear = 5, Manufacturer = "Bus_Liaz"},
                    new Transmission() {Type = "Manual", Gear = 5, Manufacturer = "Bus_Scania"},
                    new Transmission() {Type = "Auto",   Gear = 6, Manufacturer = "Bus_Man"},
                    new Transmission() {Type = "Manual", Gear = 6, Manufacturer = "Bus_Volvo"},
                    new Transmission() {Type = "Auto",   Gear = 5,  Manufacturer = "Bus_Mersedes"},
                    new Transmission() {Type = "Auto",   Gear = 1, Manufacturer = "Scooter_Urban"},
                    new Transmission() {Type = "Auto",   Gear = 1, Manufacturer = "Scooter_Xiaomi"},
                    new Transmission() {Type = "Auto",   Gear = 4, Manufacturer = "Scooter_Racer"},
                    new Transmission() {Type = "Auto",   Gear = 2, Manufacturer = "Scooter_Yamaha"},
                    new Transmission() {Type = "Auto",   Gear = 3, Manufacturer = "Scooter_Honda"}
                };
            }
            catch
            {
                Console.WriteLine("InitializationException. Please correct input Transmission data and try again!");
            }

            //Exceptions (.NET) 1.InitializationException for Auto
            try
            {
                theAutos = new List<Auto>()
                {
                    new Auto() {Type = "Car_VW Golf 4",    Year = 2005},
                    new Auto() {Type = "Car_Honda Civic",  Year = 2010},
                    new Auto() {Type = "Car_Honda Accord", Year = 2021},
                    new Auto() {Type = "Car_Acura RSX",    Year = 2020},
                    new Auto() {Type = "Car_Jeep Liberty", Year = 1995},
                    new Auto() {Type = "Lorry_Kamaz",    Year = 1997},
                    new Auto() {Type = "Lorry_Man",      Year = 2019},
                    new Auto() {Type = "Lorry_Mersedes", Year = 2015},
                    new Auto() {Type = "Lorry_Renaught", Year = 2011},
                    new Auto() {Type = "Lorry_Volvo",    Year = 2022},
                    new Auto() {Type = "Bus_Liaz",     Year = 1991},
                    new Auto() {Type = "Bus_Scania",   Year = 1998},
                    new Auto() {Type = "Bus_Man",      Year = 2009},
                    new Auto() {Type = "Bus_Volvo",    Year = 2021},
                    new Auto() {Type = "Bus_Mersedes", Year = 2022},
                    new Auto() {Type = "Scooter_Urban",  Year = 2021},
                    new Auto() {Type = "Scooter_Xiaomi", Year = 2022},
                    new Auto() {Type = "Scooter_Racer",  Year = 2022},
                    new Auto() {Type = "Scooter_Yamaha", Year = 2020},
                    new Auto() {Type = "Scooter_Honda",  Year = 2021}
                };
            }
            catch
            {
                Console.WriteLine("InitializationException. Please correct input Auto data and try again!");
            }

            // Collect all autos information in one collection.
            var autos = from auto in theAutos
                        join engine in theEngines on auto.Type equals engine.Type
                        join chassises in theChassises on auto.Type equals chassises.Type
                        join transmission in theTransmissions on auto.Type equals transmission.Manufacturer
                        select new
                        {
                            Type = auto.Type,
                            Year = auto.Year,
                            Power = engine.Power,
                            Volume = engine.Volume,
                            EngineNumber = engine.NumberEngine,
                            Wheel = chassises.Wheel,
                            Number = chassises.NumberChassis,
                            Load = chassises.Load,
                            TrasnmissionType = transmission.Type,
                            Gear = transmission.Gear,
                            Manufacturer = transmission.Manufacturer
                        };
            
            //Start first xml document 
            Console.WriteLine("\n***1. List of Vehicles(full information) with Engine Volume more than 1.5 litres ***\n");

            var bigEngine = from se in autos
                                where se.Volume > 1.5
                                select se;

            XDocument vehiclesBigEngine = new XDocument();
            XElement autoPark = new XElement("autopark");
            vehiclesBigEngine.Add(autoPark);

            foreach (var auto in bigEngine)
            {
                XElement vehicle = new XElement("vehicles");
                
                //Add attributes
                vehicle.Add(new XAttribute("Type", auto.Type));
                vehicle.Add(new XAttribute("Year", auto.Year));
                // Engine  INFO:
                string engineData = "<info>Engine  INFO:</info>";
                XElement engineInfo = XElement.Parse(engineData);
                vehicle.Add(engineInfo);
                //Add element Power
                XElement Power = new XElement("Power");
                Power.Value = auto.Power.ToString();
                vehicle.Add(Power);
                //Add element Volume
                XElement Volume = new XElement("Volume");
                Volume.Value = auto.Volume.ToString();
                vehicle.Add(Volume);
                //Add element EngineNumber
                XElement engineNumber = new XElement("enginenumber");
                engineNumber.Value = auto.EngineNumber;
                vehicle.Add(engineNumber);
                // Сhassis INFO:
                string chassisData = "<info>Сhassis  INFO:</info>";
                XElement chassisInfo = XElement.Parse(chassisData);
                vehicle.Add(chassisInfo);
                //Add element Wheel
                XElement Wheel = new XElement("Wheel");
                Wheel.Value = auto.Wheel.ToString();
                vehicle.Add(Wheel);
                //Add element Number
                XElement number = new XElement("number");
                number.Value = auto.Number;
                vehicle.Add(number);
                //Add element Load
                XElement Load = new XElement("Load");
                Load.Value = auto.Load.ToString();
                vehicle.Add(Load);
                // Transmission INFO:
                string transmissionData = "<info>Transmission INFO:</info>";
                XElement transmissionInfo = XElement.Parse(transmissionData);
                vehicle.Add(transmissionInfo);
                //Add element TrasnmissionType
                XElement trasnmissionType = new XElement("trasnmissionType");
                trasnmissionType.Value = auto.TrasnmissionType;
                vehicle.Add(trasnmissionType);
                //Add element Gear
                XElement Gear = new XElement("Gear");
                Gear.Value = auto.Gear.ToString();
                vehicle.Add(Gear);
                //Add element Manufacturer
                XElement Manufacturer = new XElement("Manufacturer");
                Manufacturer.Value = auto.Manufacturer;
                vehicle.Add(Manufacturer);

                vehiclesBigEngine.Root.Add(vehicle);

                Console.WriteLine($"  Vehicle Type: {auto.Type} - {auto.Year} Year:" +
                    $"\nEngine  INFO:\t   *Power*: {auto.Power}\t\t *Volume*: {auto.Volume}\t\t *Serial Number*: {auto.EngineNumber}\t" +
                    $"\nСhassis INFO:\t   *Wheel*: {auto.Wheel}\t\t *Number*: {auto.Number}\t *Load*: {auto.Load}\t " +
                    $"\nTransmission INFO: *Type* : {auto.TrasnmissionType}\t *Have Gears*: {auto.Gear}\t *Manufacturer*: {auto.Manufacturer}\t \n");
            }

            //Save our document in xml
            vehiclesBigEngine.Save("VehiclesBigEngine.xml");

            Console.WriteLine("***1. Saved in XML file: VehiclesBigEngine.xml ***\n");

            //Start second xml document 
            Console.WriteLine("\n***2. List of Engine Information of lorries and buses ***\n");

            var enginesLorryBus = from elb in autos
                                    where elb.Type.Contains("Lorry") || elb.Type.Contains("Bus")
                                    select elb;

            XDocument engineLorryBus = new XDocument();
            XElement enginePark = new XElement("enginepark");
            engineLorryBus.Add(enginePark);

            foreach (var auto in enginesLorryBus)
            {
                XElement vehicle = new XElement("vehicles");

                //Add attributes
                vehicle.Add(new XAttribute("Type", auto.Type));
                vehicle.Add(new XAttribute("Year", auto.Year));
                // Engine  INFO:
                string engineData = "<info>Engine  INFO:</info>";
                XElement engineInfo = XElement.Parse(engineData);
                vehicle.Add(engineInfo);
                //Add element Power
                XElement Power = new XElement("Power");
                Power.Value = auto.Power.ToString();
                vehicle.Add(Power);
                //Add element Volume
                XElement Volume = new XElement("Volume");
                Volume.Value = auto.Volume.ToString();
                vehicle.Add(Volume);
                //Add element EngineNumber
                XElement engineNumber = new XElement("enginenumber");
                engineNumber.Value = auto.EngineNumber;
                vehicle.Add(engineNumber);

                engineLorryBus.Root.Add(vehicle);

                Console.WriteLine($"  Vehicle Type: {auto.Type} - {auto.Year} Year:" +
                    $"\nEngine  INFO:\t   *Power*: {auto.Power}\t\t *Volume*: {auto.Volume}\t\t *Serial Number*: {auto.EngineNumber}\t\n");
            }

            //Save our document in xml
            engineLorryBus.Save("EnginesLorryBus.xml");

            Console.WriteLine("***2. Saved in XML file: EnginesLorryBus.xml ***\n");

            //Start third xml document 
            Console.WriteLine("\n***3. List of Vehicles(full information) with group by TrasnmissionType ***\n\n");

            var transmissionsSorter = from ts in autos
                                        orderby ts.TrasnmissionType
                                        select ts;

            XDocument transmissionSorter = new XDocument();
            XElement transmissionPark = new XElement("transmissionpark");
            transmissionSorter.Add(transmissionPark);

            foreach (var auto in transmissionsSorter)
            {
                XElement vehicle = new XElement("vehicles");

                //Add attributes
                vehicle.Add(new XAttribute("Type", auto.Type));
                vehicle.Add(new XAttribute("Year", auto.Year));
                // Engine  INFO:
                string engineData = "<info>Engine  INFO:</info>";
                XElement engineInfo = XElement.Parse(engineData);
                vehicle.Add(engineInfo);
                //Add element Power
                XElement Power = new XElement("Power");
                Power.Value = auto.Power.ToString();
                vehicle.Add(Power);
                //Add element Volume
                XElement Volume = new XElement("Volume");
                Volume.Value = auto.Volume.ToString();
                vehicle.Add(Volume);
                //Add element EngineNumber
                XElement engineNumber = new XElement("enginenumber");
                engineNumber.Value = auto.EngineNumber;
                vehicle.Add(engineNumber);
                // Сhassis INFO:
                string chassisData = "<info>Сhassis  INFO:</info>";
                XElement chassisInfo = XElement.Parse(chassisData);
                vehicle.Add(chassisInfo);
                //Add element Wheel
                XElement Wheel = new XElement("Wheel");
                Wheel.Value = auto.Wheel.ToString();
                vehicle.Add(Wheel);
                //Add element Number
                XElement number = new XElement("number");
                number.Value = auto.Number;
                vehicle.Add(number);
                //Add element Load
                XElement Load = new XElement("Load");
                Load.Value = auto.Load.ToString();
                vehicle.Add(Load);
                // Transmission INFO:
                string transmissionData = "<info>Transmission INFO:</info>";
                XElement transmissionInfo = XElement.Parse(transmissionData);
                vehicle.Add(transmissionInfo);
                //Add element TrasnmissionType
                XElement trasnmissionType = new XElement("trasnmissionType");
                trasnmissionType.Value = auto.TrasnmissionType;
                vehicle.Add(trasnmissionType);
                //Add element Gear
                XElement Gear = new XElement("Gear");
                Gear.Value = auto.Gear.ToString();
                vehicle.Add(Gear);
                //Add element Manufacturer
                XElement Manufacturer = new XElement("Manufacturer");
                Manufacturer.Value = auto.Manufacturer;
                vehicle.Add(Manufacturer);

                transmissionSorter.Root.Add(vehicle);

                Console.WriteLine($"  Vehicle Type: {auto.Type} - {auto.Year} Year \tAND *Trasnmission Type* : ***{auto.TrasnmissionType}***" +
                    $"\nEngine  INFO:\t   *Power*: {auto.Power}\t\t *Volume*: {auto.Volume}\t\t *Serial Number*: {auto.EngineNumber}\t" +
                    $"\nСhassis INFO:\t   *Wheel*: {auto.Wheel}\t\t *Number*: {auto.Number}\t *Load*: {auto.Load}\t " +
                    $"\nTransmission INFO: *Type* : {auto.TrasnmissionType}\t *Have Gears*: {auto.Gear}\t *Manufacturer*: {auto.Manufacturer}\t \n");
            }

            //Save our document in xml
            transmissionSorter.Save("TransmissionSorter.xml");
            Console.WriteLine("***3. Saved in XML file: TransmissionSorter.xml ***\n");

            //Exceptions (.NET) 2.AddException. Add new models of cars.
            try
            {
                var addEngines = new List<Engine>()
                {
                    new Engine() { Power = 80,  Volume = 1.1, Type = "Car_NEW",    NumberEngine = "Car_015"},
                    new Engine() { Power = 500, Volume = 6,   Type = "Lorry_NEW",      NumberEngine = "Lorry_060"},
                    new Engine() { Power = 520, Volume = 6.4, Type = "Bus_NEW",     NumberEngine = "Bus_064"},
                    new Engine() { Power = 140, Volume = 1.1, Type = "Scooter_NEW",  NumberEngine = "Scooter_011"}
                };

                var addChassises = new List<Сhassis>()
                {
                    new Сhassis() { Type = "Car_NEW",    Wheel = 4, NumberChassis = "CRWG_448", Load = 2400},
                    new Сhassis() { Type = "Lorry_NEW",    Wheel = 6, NumberChassis = "LK_655", Load = 5400},
                    new Сhassis() { Type = "Bus_NEW",      Wheel = 4, NumberChassis = "BSL_03K0", Load = 4400},
                    new Сhassis() { Type = "Scooter_NEW",  Wheel = 2, NumberChassis = "SC00H23", Load = 2300}
                };

                var addTransmissions = new List<Transmission>()
                {
                    new Transmission() {Type = "Manual", Gear = 5, Manufacturer = "Car_NEW"},
                    new Transmission() {Type = "Manual", Gear = 6, Manufacturer = "Lorry_NEW"},
                    new Transmission() {Type = "Manual", Gear = 5, Manufacturer = "Bus_NEW"},
                    new Transmission() {Type = "Auto",   Gear = 3, Manufacturer = "Scooter_NEW"}
                };

                var addAutos = new List<Auto>()
                {
                    new Auto() {Type = "Car_NEW",    Year = 2005},
                    new Auto() {Type = "Lorry_NEW",      Year = 2009},
                    new Auto() {Type = "Bus_NEW",    Year = 2021},
                    new Auto() {Type = "Scooter_NEW",  Year = 2021}
                };

                //Add new cars in List
                theEngines.AddRange(addEngines);
                theChassises.AddRange(addChassises);
                theTransmissions.AddRange(addTransmissions);
                theAutos.AddRange(addAutos);

                var newAutos = from auto in theAutos
                               join engine in theEngines on auto.Type equals engine.Type
                               join chassises in theChassises on auto.Type equals chassises.Type
                               join transmission in theTransmissions on auto.Type equals transmission.Manufacturer
                               select new
                               {
                                   Type = auto.Type,
                                   Year = auto.Year,
                                   Power = engine.Power,
                                   Volume = engine.Volume,
                                   EngineNumber = engine.NumberEngine,
                                   Wheel = chassises.Wheel,
                                   Number = chassises.NumberChassis,
                                   Load = chassises.Load,
                                   TrasnmissionType = transmission.Type,
                                   Gear = transmission.Gear,
                                   Manufacturer = transmission.Manufacturer
                               };

                Console.WriteLine("\n\n\t\t\t\tNEW CAR List:\n");

                foreach (var auto in newAutos)
                {
                    Console.WriteLine($"  Vehicle Type: {auto.Type} - {auto.Year} Year:" +
                        $"\nEngine  INFO:\t   *Power*: {auto.Power}\t\t *Volume*: {auto.Volume}\t\t *Serial Number*: {auto.EngineNumber}\t" +
                        $"\nСhassis INFO:\t   *Wheel*: {auto.Wheel}\t\t *Number*: {auto.Number}\t *Load*: {auto.Load}\t " +
                        $"\nTransmission INFO: *Type* : {auto.TrasnmissionType}\t *Have Gears*: {auto.Gear}\t *Manufacturer*: {auto.Manufacturer}\t \n");
                }
            }

            catch
            {
                Console.WriteLine("AddException. Please correct *new cars* information and try again!");
            }

            //Exceptions (.NET) 3.GetAutoByParameterException
            getAutoByParameter("Type", "Bus_Mersedes");
            getAutoByParameter("Year", "2020");

            //Function with GetAutoByParameterException for Exceptions (.NET)
            void getAutoByParameter(string parameter, string value)
            {
                Console.WriteLine($"\t\t Start searc by *{parameter} = {value}* \n");

                switch (parameter)
                {
                    case "Type":
                        var searchType = from se in autos
                                        where se.Type == value
                                         select se;

                        foreach (var auto in searchType)
                        {
                            Console.WriteLine($"  Vehicle Type: {auto.Type} - {auto.Year} Year:" +
                                $"\nEngine  INFO:\t   *Power*: {auto.Power}\t\t *Volume*: {auto.Volume}\t\t *Serial Number*: {auto.EngineNumber}\t" +
                                $"\nСhassis INFO:\t   *Wheel*: {auto.Wheel}\t\t *Number*: {auto.Number}\t *Load*: {auto.Load}\t " +
                                $"\nTransmission INFO: *Type* : {auto.TrasnmissionType}\t *Have Gears*: {auto.Gear}\t *Manufacturer*: {auto.Manufacturer}\t \n");
                        }
                        break;
                    case "Year":
                        var searchYear = from se in autos
                                         where se.Year == Int32.Parse(value)
                                         select se;

                        foreach (var auto in searchYear)
                        {
                            Console.WriteLine($"  Vehicle Type: {auto.Type} - {auto.Year} Year:" +
                                $"\nEngine  INFO:\t   *Power*: {auto.Power}\t\t *Volume*: {auto.Volume}\t\t *Serial Number*: {auto.EngineNumber}\t" +
                                $"\nСhassis INFO:\t   *Wheel*: {auto.Wheel}\t\t *Number*: {auto.Number}\t *Load*: {auto.Load}\t " +
                                $"\nTransmission INFO: *Type* : {auto.TrasnmissionType}\t *Have Gears*: {auto.Gear}\t *Manufacturer*: {auto.Manufacturer}\t \n");
                        }
                        break;
                    default:
                        Console.WriteLine("GetAutoByParameterException. Please correct *parametr*  and try again! ");
                        break;
                }

            }

            Console.ReadLine(); // Frendly exit
        }
    }
}
