# ejerciciosalgoritmos2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;
            Console.Write("Indica el alto del trianlgulo");
            int alto = Convert.ToInt32(

                           Console.ReadLine());
            int ancho = alto;
            for (int a = 1; a <= alto; a++)
            {

                for (int b = 1; b <= ancho; b++)

                    Console.Write("{0} ",
                                   num = alto, ancho);

                Console.WriteLine();
                ancho = ancho - 1;

            }
            Console.ReadLine();

        }
    }
}
