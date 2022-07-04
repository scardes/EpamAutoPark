using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Сhassis has field like  number of wheels, maximum load and his serialNumber
/// </summary>
namespace EpamAutoPark
{
    class Сhassis 
    {
        int wheel;
        double load;
        string numberChassis = "None";

        public Сhassis(int wheel, string numberChassis, double load)
        {
            this.wheel = wheel;
            this.numberChassis = numberChassis; 
            this.load = load;
        }

        // Print information about chassis
        public void PrintСhassis()
        {
            Console.WriteLine($"Сhassis INFO:\t   *Wheel*: {wheel}\t\t *Number*: {numberChassis}\t *Load*: {load}\t");
        }
    }
}
