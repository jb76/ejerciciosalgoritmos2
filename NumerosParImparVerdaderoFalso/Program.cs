using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosParImparVerdaderoFalso
{
    class Program
    {
        static void Main(string[] args)
        {

            float num, num2;

            Console.Write("Ingrese el valor primer valor:");
            num = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor:");
            num2 = float.Parse(Console.ReadLine());

            while (num == 0 && num2 == 0)
            {
                Console.Write("Reingrese número:");
                num = float.Parse(Console.ReadLine());
                num2 = float.Parse(Console.ReadLine());
            }

            if (num % 2 == 0 && num2 % 2 == 0)
                Console.Write("El {0} y {1}  es verdadero", num, num2);
            else
                Console.Write("El {0} y {1 }es falso", num, num2);

            Console.Read();

        }
    }
}
