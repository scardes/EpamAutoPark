using System;
using System.Collections.Generic;
using System.Text;

namespace EpamAutoPark
{
    class Transmission //"Трансмиссия" (тип, количество передач, производитель)
    {
        int gear;
        string type = "None";
        string manufacturer = "";
        
        public Transmission(string type, int gear, string manufacturer)
        {
            this.type = type; 
            this.gear = gear; 
            this.manufacturer = manufacturer;
        }
        public void PrintTransmission()
        {
            Console.WriteLine($"Transmission INFO: *Type* : {type}\t *Have Gears*: {gear}\t *Manufacturer*: {manufacturer}\t");
        }
    }
}
