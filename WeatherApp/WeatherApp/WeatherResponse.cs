using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class WeatherResponse
    {
        public string Name { set; get; }
        public MainInfo Main { set; get; }
        public SystemInfo Sys { set; get; }
        public WindInfo Wind { set; get; }
        public int Visibility { set; get; }
    }
    class MainInfo
    {
        public float Temp { set; get; }
        public int Description { set; get; }
        public int Pressure { set; get; }
        public int Humidity { set; get; }
        
    }
    class SystemInfo
    {
        public string Country { set; get; }
    }
    class WindInfo
    {
        public float Speed { set; get; }

        public int deg { set; get; }
        
    }
    class WeatherInfo
    {
        public string Description { set; get; }
    }
}
