using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Observer
{
    /// <summary>
    /// Concrete observer displaying current weather conditions.
    /// Implements both Observer and Decorator patterns.
    /// </summary>
    public class CurrentConditionsDisplay : IDisplay
    {
        private float temperature;
        private float humidity;

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {temperature}F degrees and {humidity}% humidity");
        }
    }
}
