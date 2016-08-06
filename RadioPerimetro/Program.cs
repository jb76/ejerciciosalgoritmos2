using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            float radio;

            Console.Write("Ingrese radio:");
            radio = float.Parse(Console.ReadLine());

            Console.WriteLine("El perimetro del circulo es {0}", 3.1416 * (radio * 2));
            Console.Write("El area del circulo es {0}", 3.1416 * radio * radio);
            Console.ReadLine();

        }
    }
}
