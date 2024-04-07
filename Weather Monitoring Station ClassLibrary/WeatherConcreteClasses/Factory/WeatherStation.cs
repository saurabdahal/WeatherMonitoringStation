using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Observer;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Singleton;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Factory
{
    /// <summary>
    /// Factory class for creating different types of displays.
    /// </summary>
    public static class WeatherStation
    {
        public static IDisplay CreateDisplay(DisplayType type)
        {
            _ = WeatherData.Instance;

            return type switch
            {
                DisplayType.CurrentConditions => new CurrentConditionsDisplay(),
                DisplayType.Statistics => new StatisticsDisplay(),
                DisplayType.Forecast => new ForecastDisplay(),
                _ => throw new ArgumentException("Invalid display type."),
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
