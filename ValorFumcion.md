# ejerciciosalgoritmos2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresFuncion
{
    class Program
    {
        static void Main(string[] args)
        {

            float num;

            Console.Write("Ingrese el valor de Y:");
            num = float.Parse(Console.ReadLine());

            if (num >= -5 && num <= 5)
            {
                Console.Write("El valor de es {0} ", (num * num) + (num * 2) + 1);
                Console.Read();

            }
            else


                Console.Write("ERROR.Reingrese número:");
            Console.ReadLine();
            Console.Write("presione una tecla para continuar");
            Console.ReadLine();


        }
    }
}
