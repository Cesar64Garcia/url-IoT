using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoT_Dashboard.Models
{
    public class WeatherData
    {
        public double Humidity  { get; set; }
        public double TempC { get; set; }
        public double Pressure { get; set; }
        public double TempF { get; set; }
        public double LightLvl { get; set; }
        public double BatteryLvl { get; set; }
    }
}