using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocalDigitoVariante
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                char TECLA;
                string Linea;
                Console.Write("DIGITE UNA SOLA TECLA");
                Console.WriteLine();
                Linea = Console.ReadLine();
                TECLA = char.Parse(Linea);
                switch (TECLA)
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        ; Console.WriteLine("ES UNA CIFRA NUMERICA");
                        break;
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        ; Console.WriteLine("ES UNA VOCAL MINUSCULA");
                        break;
                    case 'x':
                    case 'y':
                    case 'z':
                        ; Console.WriteLine(" ES UNA VARIANTE");
                        break;
                    default:
                        Console.WriteLine("ES UNA CONSONANTE");
                        break;
                }
                Console.WriteLine("Pulse una Tecla:"); Console.ReadLine();
            }
        }
    }


}
    

