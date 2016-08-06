# ejerciciosalgoritmos2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  LetraInversa
        {
    class Program
    {
        static void Main(string[] args)
        {
            string nombre1, nombre2, nombre3;


            Console.WriteLine("escribe la primera letra");
            nombre1 = Console.ReadLine();

            Console.WriteLine("escribe la segunda letra");
            nombre2 = Console.ReadLine();

            Console.WriteLine("escribe la tercera letra");
            nombre3 = Console.ReadLine();

            Console.WriteLine("{0} {1} {2} ",
            nombre3, nombre2, nombre1);
            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
