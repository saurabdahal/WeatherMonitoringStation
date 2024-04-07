using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Observer
{
    /// <summary>
    /// Concrete observer displaying weather forecast.
    /// Implements Observer pattern.
    /// </summary>
    public class ForecastDisplay : IDisplay, IObserver
    {
        private float lastPressure;
        private float currentPressure = 29.92f;

        public void Update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            Display();
        }

        public void Display()
        {
            if (currentPressure > lastPressure)
                Console.WriteLine("Forecast: Improving weather on the way!");
            else if (currentPressure == lastPressure)
                Console.WriteLine("Forecast: More of the same");
            else
                Console.WriteLine("Forecast: Watch out for cooler, rainy weather");
            
        }
    }
}
