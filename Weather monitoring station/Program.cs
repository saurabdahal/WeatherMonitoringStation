using System;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.DecoratorPatterb;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Factory;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Observer;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Singleton;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

class Program
{
    static void Main(string[] args)
    {
        WeatherData weatherData = WeatherData.Instance;
        IDisplay display= new ConcreteComponent();

        // Create displays using factory
        IObserver currentConditionsDisplayObserver = new CurrentConditionsDisplay(display);
        IObserver statisticsDisplayObserver = new StatisticsDisplay();
        IObserver forecastDisplayObserver = new ForecastDisplay();

        // Register displays as observers
        weatherData.RegisterObserver(currentConditionsDisplayObserver);
        weatherData.RegisterObserver(statisticsDisplayObserver);
        weatherData.RegisterObserver(forecastDisplayObserver);

        // Simulate weather changes
        weatherData.SetMeasurements(75.0f, 60.0f, 30.4f);
        Console.WriteLine("\n==========================================\n");
        weatherData.SetMeasurements(80.0f, 65.0f, 29.2f);
        Console.WriteLine("==========================================\n");
        weatherData.SetMeasurements(72.0f, 55.0f, 30.0f);

    }
}
