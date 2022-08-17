using System;

/// <summary>
/// Transmission has field like type of transmission, number of gears and his manufacturer
/// </summary>
namespace EpamAutoPark
{
    class Transmission
    {
        int gear = 0;
        public int Gear
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Gear should be greater than 0");
                }
                else
                {
                    gear = value;
                }
            }
            get
            {
                return gear;
            }
        }
        public string Type { get; set; }
        public string Manufacturer { get; set; }

    }
}
