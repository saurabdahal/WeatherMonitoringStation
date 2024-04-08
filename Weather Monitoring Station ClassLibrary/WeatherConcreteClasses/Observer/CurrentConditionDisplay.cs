using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.Metrics;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.DecoratorPattern;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Observer
{
    /// <summary>
    /// This is a concrete observer class displaying current weather conditions.
    /// It implements both Observer and Decorator patterns.
    /// Implementation of Decorator pattern is done by extending the base decorator class then overriding the Display method
    /// </summary>
    /// <Author>Saurav Dahal</Author>
    public class CurrentConditionsDisplay(IDisplay display) : Decorator(display), IObserver
    {
        private float temperature;
        private float humidity;
        private float rain;

        public void Update(WeatherMetrics weatherMetrics)
        {
            this.temperature = weatherMetrics.Temperature;
            this.humidity = weatherMetrics.Humidity;
            this.rain = weatherMetrics.RainProb;
            Display();
        }

        /// <summary>
        /// Displays the weather condition. It also extends the base method by adding few relevant information to the method display.
        /// </summary>
        public override void Display()
        {
            DateTime now = DateTime.Now;

            string todayDate = now.ToString("MMMM dd, yyyy");
            string currentTime = now.ToString("hh:mm:ss tt");

            Console.Write($"Today is {todayDate} and time is {currentTime}.");
            display.Display();
            Console.WriteLine($"Current Weather Conditions: Temperature is {temperature} C and {humidity}% humidity. The probability of rain is {rain}%");
        }
    }
}
