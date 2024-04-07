using System.Collections.Generic;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Singleton
{
    /// <summary>
    /// Singleton class representing weather data.
    /// </summary>
    public sealed class WeatherData
    {
        // Singleton instance (thread-safe using static initialization)
        private static readonly WeatherData instance = new WeatherData();

        // Public property to access the singleton instance
        public static WeatherData Instance => instance;

        private readonly List<IDisplay> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        // Private constructor to prevent instantiation
        private WeatherData()
        {
            observers = new List<IDisplay>();
        }

        public void RegisterObserver(IDisplay observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IDisplay observer)
        {
            observers.Remove(observer);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            // Update weather data
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            // Notify all observers when weather data changes
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                // Update each observer with the latest weather data
                observer.Update(temperature, humidity, pressure);
            }
        }
    }
}
