using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Engine has field like power, volume, type of engine and his serialNumber
/// </summary>
namespace EpamAutoPark
{
    class Engine
    {
        public int power { get; set; }
        public double volume { get; set; }
        public string type { get; set; }
        public string numberEngine { get; set; }
        
        // Print information about engine
        public void PrintEngine()
        {
            Console.WriteLine($"Engine INFO:\t   *Power*: {power}\t\t *Volume*: {volume}\t\t *Type*: {type}\t *Serial Number*: {numberEngine}\t");
        }
    }
}
