using System;

namespace _05_Temperature
{
    
    public class Temperature
    {
        public double Fahrenheit;
        public double Celcius;
    
        public static double FahrenheitToCelcius(double v)

        {
            double c = (v - 32) * 5.0 / 9.0;
            return c;

        }
        public static double CelciusToFahrenheit(double v)
        {
            double f = v * 9.0/5.0 + 32;
            return f;
        }
    }
 
}