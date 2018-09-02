using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using IoT_Dashboard.Models;
using Newtonsoft.Json;

namespace IoT_Dashboard.Hubs
{
    [HubName("weather")]
    public class Weather : Hub
    {
        private static IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<Weather>();

        public void Hello()
        {
            Clients.All.hello();
        }

        public static void SendWeather(string weather)
        {
            WeatherData info = JsonConvert.DeserializeObject<WeatherData>(weather);
            hubContext.Clients.All.update(info.TempC, info.TempF, info.Humidity, info.Pressure, info.LightLvl);
        }
    }
}