using System;
using Weather_Monitoring_Station_ClassLibrary.Metrics;
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
        weatherData.SetMeasurements(new WeatherMetrics(20.0f, 40.0f, 30.4f, 0.0f));
        Console.WriteLine("\n==========================================\n");

        weatherData.SetMeasurements(new WeatherMetrics(23.0f, 80.0f, 66.0f, 8.0f));
        Console.WriteLine("==========================================\n");

        weatherData.SetMeasurements(new WeatherMetrics(-5.0f, 35.0f, 60.0f, 50.0f));

        //        public WeatherMetrics(float temperature, float humidity, float pressure, float rainProb)

        //         private float currentPressure = 48.55f;
        //private float currentTemperature = 20.0f;
        //if (currentPressure > lastPressure && rain < 10.0f && (temperature > currentTemperature - 5.0f && temperature < currentTemperature + 5.0f))
        //    Console.WriteLine("Forecast: This week's weather looks great !!! ");
        //else if (currentPressure == lastPressure && (rain >= 0.0f && rain <= 5.0f) && temperature == currentTemperature)
        //    Console.WriteLine("Forecast: No significant change in current weather for the week");
        //else
        //    Console.WriteLine("Forecast: Weather is unpredictable this week. Probability of rain.");

    }
}
