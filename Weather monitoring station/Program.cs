using System;
using Weather_Monitoring_Station_ClassLibrary.Metrics;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.DecoratorPatterb;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Observer;
using Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Singleton;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

class Program
{
    static void Main(string[] args)
    {
        WeatherData weatherData = WeatherData.Instance;
        IDisplay display= new ConcreteComponent();

        // here we add the displays to the display manager
        IObserver currentConditionsDisplayObserver = new CurrentConditionsDisplay(display);
        IObserver statisticsDisplayObserver = new StatisticsDisplay();
        IObserver forecastDisplayObserver = new ForecastDisplay();

        // here we register the observer
        weatherData.RegisterObserver(currentConditionsDisplayObserver);
        weatherData.RegisterObserver(statisticsDisplayObserver);
        weatherData.RegisterObserver(forecastDisplayObserver);

        // This is a simulation of weather station.
        weatherData.SetMeasurements(new WeatherMetrics(20.0f, 40.0f, 30.4f, 0.0f));
        Console.WriteLine("\n==========================================\n");

        weatherData.SetMeasurements(new WeatherMetrics(23.0f, 80.0f, 66.0f, 8.0f));
        Console.WriteLine("==========================================\n");

        weatherData.SetMeasurements(new WeatherMetrics(-5.0f, 35.0f, 60.0f, 50.0f));


    }
}
