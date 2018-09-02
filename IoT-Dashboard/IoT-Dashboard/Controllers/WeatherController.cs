using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IoT_Dashboard.Controllers
{
    public class WeatherController : ApiController
    {
        // GET api/Weather/5
        [AllowAnonymous]
        public string Get()
        {
            return "Push API v.1.0.0";
        }

        // POST api/weather
        [AllowAnonymous]
        public void Post([FromBody] string value)
        {
            IoT_Dashboard.Hubs.Weather.SendWeather(value);
        }
    }
}