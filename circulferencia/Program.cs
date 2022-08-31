using System;
using System.Globalization;

namespace circunferencia
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), 
                CultureInfo.InvariantCulture);

            double cir = Circunferencia(raio);

            double volume = Volume(raio);
        }

        static double Circunferencia (double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume (double r)
        {
            return 4.0 / 3.0 * Pi * r * r;
        }

    }
}
