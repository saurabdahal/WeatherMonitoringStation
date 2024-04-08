using System;
using Weather_Monitoring_Station_ClassLibrary.Metrics;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Observer
{
    /// <summary>
    /// This class represents concrete observer that displays weather statistics.
    /// </summary>
    /// <Author>Saurav Dahal</Author>
    public class StatisticsDisplay : IDisplay, IObserver
    {
        // Fields to track temperature statistics
        private float maxTemperature = float.MinValue;
        private float minTemperature = float.MaxValue;
        private float temperatureSum = 0;
        private int numReadings = 0;

        /// <summary>
        /// Updates temperature statistics based on the received weather metrics.,called by the WeatherData which is the Subject, to notify new weather metrics.
        /// </summary>
        /// <param name="weatherMetrics"></param>
        public void Update(WeatherMetrics weatherMetrics)
        {
            // Update temperature sum and number of readings
            temperatureSum += weatherMetrics.Temperature;
            numReadings++;

            // Update max and min temperatures
            if (weatherMetrics.Temperature > maxTemperature)
                maxTemperature = weatherMetrics.Temperature;

            if (weatherMetrics.Temperature < minTemperature)
                minTemperature = weatherMetrics.Temperature;

            // Display updated statistics
            Display();
        }

        /// <summary>
        /// Display method to show the current temperature statistics. Displays min temperature , max temperature and average temperature.
        /// </summary>
        public void Display()
        {
            // Display min, average, and max temperatures
            Console.WriteLine($"Min temperature = {minTemperature}");
            Console.WriteLine($"Average temperature = {temperatureSum / numReadings}");
            Console.WriteLine($"Max temperature = {maxTemperature}");
        }
    }
}
