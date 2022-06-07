using System;
using System.Collections.Generic;
using System.Text;

namespace EpamAutoPark
{
    class Transmission //"Трансмиссия" (тип, количество передач, производитель).
    {
        string type = "None";
        int gear;
        string manufacturer = "";

        public Transmission(string ty, int ge, string man)
        {
            type = ty; gear = ge; manufacturer = man;
        }
        public void PrintTransmission()
        {
            Console.WriteLine($"Transmission INFO: *Type* : {type}\t *Have Gears*: {gear}\t *Manufacturer*: {manufacturer}\t");
        }
    }
}
