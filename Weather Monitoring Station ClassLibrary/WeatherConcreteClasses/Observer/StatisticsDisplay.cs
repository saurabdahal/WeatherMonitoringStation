using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.Metrics;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Observer
{
    /// <summary>
    /// Concrete observer displaying weather statistics.
    /// Implements Observer pattern.
    /// </summary>
    public class StatisticsDisplay : IDisplay, IObserver
    {
        private float maxTemperature = float.MinValue;
        private float minTemperature = float.MaxValue;
        private float temperatureSum = 0;
        private int numReadings = 0;

        public void Update(WeatherMetrics weatherMetrics)
        {
            temperatureSum += weatherMetrics.Temperature;
            numReadings++;

            if (weatherMetrics.Temperature > maxTemperature)
                maxTemperature = weatherMetrics.Temperature;

            if (weatherMetrics.Temperature < minTemperature)
                minTemperature = weatherMetrics.Temperature;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Min temperature = {minTemperature}");
            Console.WriteLine($"Average temperature = {temperatureSum / numReadings}");
            Console.WriteLine($"Max temperature ={maxTemperature}");
        }
    }
}
