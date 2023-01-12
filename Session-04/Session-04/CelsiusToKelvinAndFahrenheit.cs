using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class CelsiusToKelvinAndFahrenheit
    {
        double celsius = 50.3;

        public void convertCelsius()
        {
            Console.WriteLine("//    Program Number  #7      //\n");
            double kelvin = celsius + 273.15;
            double fahrenheit =(celsius * 9.0 / 5.0) + 32.0;

            Console.WriteLine("Celsius is: " + Math.Floor(celsius) +
                              "\nCelsius converted to Kelvin is: " + Math.Round(kelvin) +
                              "\nCelsius converted to Fahrenheit is: " + Math.Round(fahrenheit));
        }
    }
}
