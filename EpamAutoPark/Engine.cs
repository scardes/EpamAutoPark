using System;
using System.Collections.Generic;
using System.Text;

namespace EpamAutoPark
{
    class Engine //"Двигатель"(включает в себя поля мощность, объем, тип, серийный номер),
    {
        public int power;
        public double volume;
        public string type = "None";
        public string numberEngine = "None";

        public Engine(int pow, double vol, string typ, string num)
        {
            power = pow; volume = vol; type = typ; numberEngine = num;
        }
        public void PrintEngine()
        {
            Console.WriteLine($"Engine INFO:\t   *Power*: {power}\t *Volume*: {volume}\t *Type*: {type}\t *Serial Number*: {numberEngine}\t");
        }
    }
}
