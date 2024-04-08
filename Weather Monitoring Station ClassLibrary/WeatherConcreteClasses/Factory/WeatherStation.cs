using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.DecoratorPatterb;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Observer;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Singleton;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Factory
{
    /// <summary>
    /// This is the factory class for creating different types of displays.
    /// </summary>
    /// <Author>Saurav Dahal</Author>
    public static class WeatherStation
    {
        static IDisplay display = new ConcreteComponent();

        /// <summary>
        /// Creates a display object based on the specified display type. If the display type does not match the DisplayType defined in enum, exception is thrown
        /// </summary>
        /// <param name="type">The type of display to create.</param>
        /// <returns>An instance of IDisplay.</returns>
        public static IDisplay CreateDisplay(DisplayType type)
        {
            _ = WeatherData.Instance;

            return type switch
            {
                DisplayType.CurrentConditions => new CurrentConditionsDisplay(display),
                DisplayType.Statistics => new StatisticsDisplay(),
                DisplayType.Forecast => new ForecastDisplay(),
                _ => throw new ArgumentException("Unsupported display type."),
            };
        }
    }

    public enum DisplayType
    {
        CurrentConditions,
        Statistics,
        Forecast
    }
}
