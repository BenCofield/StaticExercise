using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise 
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius (double F)
        {

            double C = (5.0 / 9.0) * (F - 32);
            return C;
        }
        public static double CelsiusToFahrenheit (double C)
        {
            double F = (9.0 / 5.0 * C) + 32;
            return F;
        }
    }
}
