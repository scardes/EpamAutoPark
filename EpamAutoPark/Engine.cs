using System;

/// <summary>
/// Engine has field like power, volume, type of engine and his serialNumber
/// </summary>
namespace EpamAutoPark
{
    public class Engine
    {
        int power = 0;
        double volume = 0;
        public int Power 
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Power should be greater than 0");
                }
                else
                {
                    power = value;
                }    
            }
            get 
            { 
                return power; 
            }
        }
        public double Volume
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Volume should be greater than 0");
                }
                else
                {
                    volume = value;
                }
            }
            get
            {
                return volume;
            }
        }
        public string Type { get; set; }
        public string NumberEngine { get; set; }
        
    }
}
