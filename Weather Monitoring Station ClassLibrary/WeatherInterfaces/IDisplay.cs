using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces
{
    /// <summary>
    /// Interface for display elements.
    /// </summary>
    public interface IDisplay
    {
        void Update(float temperature, float humidity, float pressure);
    }

}
