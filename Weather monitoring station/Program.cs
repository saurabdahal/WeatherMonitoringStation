using System;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Factory;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Singleton;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

class Program
{
    static void Main(string[] args)
    {
        WeatherData weatherData = WeatherData.Instance;

        // Create displays using factory
        IDisplay currentConditionsDisplay = WeatherStation.CreateDisplay(DisplayType.CurrentConditions);
        IDisplay statisticsDisplay = WeatherStation.CreateDisplay(DisplayType.Statistics);
        IDisplay forecastDisplay = WeatherStation.CreateDisplay(DisplayType.Forecast);

        // Register displays as observers
        weatherData.RegisterObserver(currentConditionsDisplay);
        weatherData.RegisterObserver(statisticsDisplay);
        weatherData.RegisterObserver(forecastDisplay);

        // Simulate weather changes
        weatherData.SetMeasurements(75.0f, 60.0f, 30.4f);
        weatherData.SetMeasurements(80.0f, 65.0f, 29.2f);
        weatherData.SetMeasurements(72.0f, 55.0f, 30.0f);

        // Unregister displays (optional)
        weatherData.RemoveObserver(statisticsDisplay);
    }
}
