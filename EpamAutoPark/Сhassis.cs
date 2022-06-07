using System;
using System.Collections.Generic;
using System.Text;

namespace EpamAutoPark
{
    class Сhassis //"Шасси"(количество колес, номер, допустимая нагрузка)
    {
        public int wheel;
        public string numberChassis = "None";
        public double load;

        public Сhassis(int whe, string num, double loa)
        {
            wheel = whe; numberChassis = num; load = loa;
        }
        public void PrintСhassis()
        {
            Console.WriteLine($"Сhassis INFO:\t   *Wheel*: {wheel}\t *Number*: {numberChassis}\t *Load*: {load}\t");
        }
    }
}
