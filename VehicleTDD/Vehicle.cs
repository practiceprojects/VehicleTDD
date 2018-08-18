using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTDD
{
    public class Vehicle
    {
        public Vehicle()
        { // DEFAULT CTOR
        }

        public string color { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public double engSize { get; set; }
        public int rimSize { get; set; }

        public Vehicle(string color, string make, string model, string year, double engSize, int rimSize)
        {
            this.color = color;
            this.make = make;
            this.model = model;
            this.year = year;
            this.engSize = engSize;
            this.rimSize = rimSize;
        }

        public double GetMph(double distance, double time)
        {
            if (time == 0)
            {
                return 0;
            }
            return distance / time;
        }

        public double GetMph(double distance, TimeSpan time)
        {
            double hours = time.TotalHours;
            return GetMph(distance, hours);
        }

        //public double GetMpg(double endOdo, double startOdo, double tankSize)
        //{
        //    return 49.94;
        //}
    }
}
