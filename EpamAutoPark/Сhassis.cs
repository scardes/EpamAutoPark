using System;

/// <summary>
/// Сhassis has field like  number of wheels, maximum load and his serialNumber
/// </summary>
namespace EpamAutoPark
{
    public class Сhassis 
    {
        int wheel = 0;
        double load = 0;
        public int Wheel
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Wheel should be greater than 0");
                }
                else
                {
                    wheel = value;
                }
            }
            get
            {
                return wheel;
            }
        }
        public double Load
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Load should be greater than 0");
                }
                else
                {
                    load = value;
                }
            }
            get
            {
                return load;
            }
        }
        public string Type { get; set; }
        public string NumberChassis { get; set; }
    }
}
