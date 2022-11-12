using System;
using Temperature.Services;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Celcius C = new Celcius(100);

            Kelvin K = C;

            Console.WriteLine(K.Degree);

        }
    }
}
