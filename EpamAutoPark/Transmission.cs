using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Transmission has field like type of transmission, number of gears and his manufacturer
/// </summary>
namespace EpamAutoPark
{
    class Transmission
    {
        public int gear { get; set; }
        public string type { get; set; }
        public string manufacturer { get; set; }

        //public Transmission(string type, int gear, string manufacturer)
        //{
        //    this.type = type; 
        //    this.gear = gear; 
        //    this.manufacturer = manufacturer;
        //}

        // Print information about transmission
        public void PrintTransmission()
        {
            Console.WriteLine($"Transmission INFO: *Type* : {type}\t *Have Gears*: {gear}\t *Manufacturer*: {manufacturer}\t");
        }
    }
}
