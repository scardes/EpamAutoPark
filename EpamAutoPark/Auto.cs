using System;

/// <summary>
/// Auto has type of vehicle (key for join) and year of vehicles
/// </summary>
namespace EpamAutoPark
{
    class Auto
    {
        int year = 1900;
        int currentYear = DateTime.Now.Year;
        public int Year
        {
            set
            {
                if (value < 1900 || value > currentYear)
                {
                    Console.WriteLine("Year should be greater than 1900 and less then current year ");
                }
                else
                {
                    year = value;
                }
            }
            get
            {
                return year;
            }
        }

        public string Type { get; set; }
    }
}
