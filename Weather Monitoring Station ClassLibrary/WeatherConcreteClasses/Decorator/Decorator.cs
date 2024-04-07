using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.Decorator
{
    public class Decorator(IDisplay display) : IDisplay
    {
        protected IDisplay display = display;

        public virtual void Display()
        {
           
        }
    }
}
