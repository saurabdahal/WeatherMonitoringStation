using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses
{
    /// <summary>
    /// Concrete observer displaying weather statistics.
    /// Implements Observer pattern.
    /// </summary>
    public class StatisticsDisplay : IDisplay
    {
        private float maxTemperature = float.MinValue;
        private float minTemperature = float.MaxValue;
        private float temperatureSum = 0;
        private int numReadings = 0;

        public void Update(float temperature, float humidity, float pressure)
        {
            temperatureSum += temperature;
            numReadings++;

            if (temperature > maxTemperature)
                maxTemperature = temperature;

            if (temperature < minTemperature)
                minTemperature = temperature;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {temperatureSum / numReadings}/{maxTemperature}/{minTemperature}");
        }
    }
}
