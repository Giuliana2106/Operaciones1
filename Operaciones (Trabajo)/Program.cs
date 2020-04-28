using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operaciones__Trabajo_
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            char menu = 'n';
            double n1 = 0;
            double n2 = 0;
            double total = 0;
            string linea = "";


            while (menu != 's') ;

            {
                Console.WriteLine("1.-suma");
                Console.WriteLine("2.-resta");
                Console.WriteLine("3.-multiplicación");
                Console.WriteLine("4.-división");
                Console.WriteLine("5.-salir");
                Console.WriteLine("opción: ");


                linea = Console.ReadLine();
                op = int.Parse(linea);



                Console.WriteLine("ingrese el primer valor: ");
                linea = Console.ReadLine();
                n1 = int.Parse(linea);

                Console.WriteLine("ingrese el segundo valor: ");
                linea = Console.ReadLine();
                n2 = int.Parse(linea);

                if (op == 1)
                {
                    total = n1 + n2;
                    Console.WriteLine("El resultado es: ");
                }
                else if (op == 2)
                {
                    total = n1 - n2;
                    Console.WriteLine("El resultado es: ");
                }
                else if (op == 3)
                {
                    total = n1 * n2;
                    Console.WriteLine("El resultado es: ");
                }
                else if (op == 4)
                {
                    total = n1 / n2;
                    Console.WriteLine("El resultado es: ");
                }
                else if (op == 5)
                {
                    Console.WriteLine("desea salir [s/n] ");
                    linea = Console.ReadLine();
                    menu = char.Parse(linea);
                }


            }
        }
    }
}
