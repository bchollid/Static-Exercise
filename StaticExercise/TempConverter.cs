using System;
namespace StaticExercise
{
	public static class TempConverter
	{

        public static decimal FahrenheitToCelsius(decimal temp)
        {
            decimal conversion;
            conversion = (temp - 32) * 5 / 9;
            return conversion;
        }
        public static decimal CelsiusToFahrenheit(decimal temp)
        {
            //(0°C × 9 / 5) +32 = 32°F
            decimal conversion;
            conversion = (temp * 9 / 5) + 32;
            return conversion;

        }
    }
}

