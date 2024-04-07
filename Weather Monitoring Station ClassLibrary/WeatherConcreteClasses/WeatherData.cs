using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses
{
   

    /// <summary>
    /// Singleton class representing weather data.
    /// </summary>
    public sealed class WeatherData
    {
        private static readonly Lazy<WeatherData> instance = new Lazy<WeatherData>(() => new WeatherData());

        public static WeatherData Instance => instance.Value;

        private readonly List<IDisplay> observers;
        private float temperature;
        private float humidity;
        private float pressure;

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
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
    }

}
