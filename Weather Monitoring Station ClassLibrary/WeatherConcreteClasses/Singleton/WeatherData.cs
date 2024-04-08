using System.Collections.Generic;
using Weather_Monitoring_Station_ClassLibrary.Metrics;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Singleton
{
    /// <summary>
    /// This is a singleton class which also acts as the subject for the observer pattern.
    /// </summary>
    public class WeatherData
    {
        /*
         * This is an example of lazy initialization. The WeatherData is initialized first only when it is accessed
         * and if it is accessed again then the get method is called and the instance is returned. For any subsequent access
         * will not create the instance and rather return the instance.
         */
        public static WeatherData Instance { get; } = new WeatherData();

        private readonly List<IObserver> observers;
        private WeatherMetrics weatherMetrics;

        // Private constructor to prevent instantiation
        private WeatherData()
        {
            observers = [];
        }

        /// <summary>
        /// adds observer to the observers list
        /// </summary>
        /// <param name="observer"></param>
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// removes observer from observers list
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// this method does two things:
        ///     1. sets the value to the fields
        ///     2. as soon as the value in the field is changed, it also notiifies all the observers about the change in value of the fields
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void SetMeasurements(WeatherMetrics metrics)
        {
            // Update weather data
            this.weatherMetrics = metrics;

            // Notify all observers when weather data changes
            NotifyObservers();
        }

        /// <summary>
        /// this method notifies all the obervers by calling their update method
        /// </summary>
        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                // Update each observer with the latest weather data
                observer.Update(weatherMetrics);
            }
        }
    }
}
