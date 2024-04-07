using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_Monitoring_Station_ClassLibrary.WeatherInterfaces;

namespace Weather_Monitoring_Station_ClassLibrary.WeatherConcreteClasses.DecoratorPatterb
{
    public class ConcreteComponent : IDisplay
    {
        public void Display()
        {
            Console.Write("Today's weather is Sunny.");
        }
    }
}
