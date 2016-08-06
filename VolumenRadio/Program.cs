
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumenRadio
{
    class Program
    {
        static void Main(string[] args)
        {
                        double pi, radio, area, volumen, longitud;
            pi = 3.14;
            Console.Write("Ingrese el radio de la circunferencia:");
            radio = int.Parse(Console.ReadLine());
            longitud = 2 * pi * radio;
            area = Math.Round(pi * Math.Pow(radio, 2), 2);
            volumen = Math.Round((4 / 3) * pi * Math.Pow(radio, 3), 2);
            Console.WriteLine("");
            Console.WriteLine("Longitud de la circunferencia:" + longitud);
            Console.WriteLine("Area de la circunferencia: " + area);
            Console.WriteLine("Volumen de la circunferencia: " + volumen);
            Console.ReadLine();

        }
    }
}
