using System;
using System.Globalization;
namespace circ02
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write("Entre com o valor do raio");
            double raio = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            double cir = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circunferência: " +
                cir.ToString("F2", 
                CultureInfo.InvariantCulture));  
            Console.WriteLine("Volume: " +
                volume.ToString("F2", 
                CultureInfo.InvariantCulture)); 
            Console.WriteLine("Volume: " +
                calc.Pi.ToString("F2",
                CultureInfo.InvariantCulture));
        }
    }
}
