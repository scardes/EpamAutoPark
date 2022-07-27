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
        public string type { get; set; }
        public int wheel { get; set; }
        public double load { get; set; }
        public string numberChassis { get; set; }
             
        // Print information about chassis
        public void PrintСhassis()
        {
            Console.WriteLine($"Сhassis INFO:\t   *Wheel*: {wheel}\t\t *Number*: {numberChassis}\t *Load*: {load}\t");
        }
    }
}
