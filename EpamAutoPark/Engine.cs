using System;
using System.Collections.Generic;
using System.Text;

namespace EpamAutoPark
{
    class Engine //"Двигатель"(поля мощность, объем, тип, серийный номер)
    {
        int power;
        double volume;
        string type = "None";
        string numberEngine = "None";

        public Engine(int power, double volume, string type, string numberEngine)
        {
            this.power = power;
            this.volume = volume;
            this.type = type;
            this.numberEngine = numberEngine;
        }
        public void PrintEngine()
        {
            Console.WriteLine($"Engine INFO:\t   *Power*: {power}\t\t *Volume*: {volume}\t\t *Type*: {type}\t *Serial Number*: {numberEngine}\t");
        }
    }
}
