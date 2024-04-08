using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.DecoratorPattern
{
    /// <summary>
    /// Defines the decorator component for the decorator pattern. It implements IDisplay interface.
    /// </summary>
    /// <param name="display"></param>
    /// <Author>Saurav Dahal</Author>
    public class Decorator(IDisplay display) : IDisplay
    {
        protected IDisplay display = display;

        public virtual void Display()
        {
           
        }
    }
}
