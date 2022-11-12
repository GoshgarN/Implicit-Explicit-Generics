using System;
using System.Collections.Generic;
using System.Text;

namespace Temperature.Services
{
   public class Celcius 
    {
        public double Degree { get; set; }

        public Celcius(double C)
        {
            Degree = C;
        }

        public static implicit operator Kelvin(Celcius C)
        {
            return new Kelvin(C.Degree / 273);
        }

    }
}
