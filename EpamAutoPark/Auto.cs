using System;
using System.Collections.Generic;
using System.Text;

namespace EpamAutoPark
{
    class Auto
    {
        public string type { get; set; }
        public int year { get; set; }

        public void PrintAuto()
        {
            Console.WriteLine($"AUTO  INFO: *Type* : {type}\t *Year*: {year}\t");
        }
    }
}
