using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.Metrics;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces
{
    public interface IObserver
    {
        /// <summary>
        /// Update method called when the subject's data changes.
        /// </summary>
        /// <param name="subject">The subject that has changed.</param>
        void Update(WeatherMetrics wm);
    }
}
