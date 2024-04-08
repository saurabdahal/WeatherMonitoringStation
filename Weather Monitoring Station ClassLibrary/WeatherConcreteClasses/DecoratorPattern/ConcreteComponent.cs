using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.DecoratorPatterb
{
    /// <summary>
    /// This class defines a basic display component by implemenenting the IDisplay interface. It acts as the concerete class for the pattern
    /// </summary>
    /// <Author>Saurav Dahal</Author>
    public class ConcreteComponent : IDisplay
    {
        public void Display()
        {
            Console.Write("Today's weather is Sunny.");
        }
    }
}
