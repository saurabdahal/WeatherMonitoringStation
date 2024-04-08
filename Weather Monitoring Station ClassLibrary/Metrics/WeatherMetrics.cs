using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Monitoring_Station_ClassLibrary.Metrics
{
    public class WeatherMetrics
    {
        public float Temperature { get; }
        public float Humidity { get; }
        public float Pressure { get; }

        public float RainProb { get; }

        public WeatherMetrics(float temperature, float humidity, float pressure, float rainProb)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            RainProb = rainProb;
        }
    }
}
