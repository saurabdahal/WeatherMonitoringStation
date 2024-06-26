﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.Metrics;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Observer
{
    /// <summary>
    /// This is concrete observer that weather forecast as soon it is notified of the change.
    /// </summary>
    /// <Author>Saurav Dahal</Author>
    public class ForecastDisplay : IDisplay, IObserver
    {
        private float lastPressure;
        private float currentPressure = 48.55f;
        private float currentTemperature = 20.0f;
        private float temperature;
        private float rain;

        /// <summary>
        /// Updates the field values as soon as it is notified of the change. 
        /// </summary>
        /// <param name="weatherMetrics"></param>
        public void Update(WeatherMetrics weatherMetrics)
        {
            lastPressure = currentPressure;
            currentPressure = weatherMetrics.Pressure;

            temperature = currentTemperature;
            currentTemperature = weatherMetrics.Temperature;

            rain = weatherMetrics.RainProb;

            Display();
        }

        /// <summary>
        /// This is the implementation of IDisplay interface.Displays Forecasted information.
        /// </summary>
        public void Display()
        {

            if (currentPressure > lastPressure && rain < 10.0f && (temperature > (currentTemperature - 5.0f) && temperature < (currentTemperature + 5.0f)) )
                Console.WriteLine("Forecast: This week's weather looks great !!! ");
            else if (currentPressure == lastPressure && (rain >= 0.0f && rain <= 5.0f) && temperature == currentTemperature)
                Console.WriteLine("Forecast: No significant change in current weather for the week");
            else
                Console.WriteLine("Forecast: Weather is unpredictable this week. Probability of rain.");
            
        }
    }
}
