using System;
using System.Collections.Generic;
using System.Text;

namespace EpamAutoPark
{
    class Сhassis //"Шасси"(количество колес, номер, допустимая нагрузка)
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
        public void PrintСhassis()
        {
            Console.WriteLine($"Сhassis INFO:\t   *Wheel*: {wheel}\t\t *Number*: {numberChassis}\t *Load*: {load}\t");
        }
    }
}
