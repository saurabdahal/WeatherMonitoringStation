using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.DecoratorPattern;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Observer
{
    /// <summary>
    /// Concrete observer displaying current weather conditions.
    /// It implements both Observer and Decorator patterns.
    /// Implementation of Decorator pattern is done by extending the base decorator class then overriding the Display method
    /// </summary>
    public class CurrentConditionsDisplay(IDisplay display) : Decorator(display), IObserver
    {
        private float temperature;
        private float humidity;

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        /// <summary>
        /// Displays the weather condition. It also extends the base method by adding few relevant information to the method display.
        /// </summary>
        public override void Display()
        {
            display.Display();
            Console.WriteLine($"Current Conditions: {temperature}F degrees and {humidity}% humidity");
        }
    }
}
