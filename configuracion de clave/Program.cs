using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configuracion_de_clave
{
    class Program
    {
        static void Main(string[] args)
        {

            int clave = 0, clav, sw, s = 0, op;
            do
            {
                do
                {

                    Console.Write("\n\n CONFIGURACION DE CLAVE");
                    Console.Write("\n  1. Guardar clave");
                    Console.Write("\n  2. Acceder");
                    Console.Write("\n  3. Salir");
                    Console.Write("\n\n  Su opción es: ");
                    op = int.Parse(Console.ReadLine());
                    if (op < 1 || 3 < op)
                    {
                        Console.Write("\n\t ¡No existe esa opción!");
                        Console.Write("\n\t Pulse una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                while (op < 1 || 3 < op);
                switch (op)
                {
                    case 1:
                        Console.Clear();//Clear es la funcion para limpiar pantalla.

                        Console.Write("\n\n  Guerdar clave: ");
                        clave = int.Parse(Console.ReadLine()); //almacena valor en variable, la funcion Parse convierte el valor tipo caracter a numero entero.
                        Console.Write("\n\n  ¡Clave guardada!");
                        Console.Write("\n\t Presione una tecla para continuar...");
                        Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                        s = 1;
                        break;
                    case 2:
                        if (s == 1)
                        {
                            do
                            {
                                Console.Clear();

                                Console.Write("\n\n  Ingrese la clave: ");
                                clav = int.Parse(Console.ReadLine());
                                if (clav == clave)
                                {
                                    Console.Write("\n  Bienvenido");
                                    sw = 1;
                                    Console.Write("\n\t Presione una tecla para continuar...");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.Clear();

                                    Console.Write("\n  Error Clave");
                                    sw = 0;
                                    s = s + 1;
                                    Console.Write("\n\t Presione una tecla para continuar...");
                                    Console.ReadKey();
                                }
                                if (s == 4)
                                {

                                    Console.Clear();

                                    Console.Write("\n\n  Has hecho 3 intentos seras sacado.");
                                    Console.Write("\n\t Presione una tecla para continuar...");
                                    Console.ReadKey();
                                    sw = 1;
                                    s = 1;
                                }
                            }
                            while (sw != 1);
                        }
                        else
                        {
                            Console.Clear();
                            Console.Write("\n\n  Guarde primero la clave.");
                            Console.Write("\n\t Presione una tecla para continuar...");
                            Console.ReadKey();
                        }

                        break;

                    default:
                        Console.Clear();

                        Console.WriteLine("\n\n Estas saliendo del programa");
                        Console.Write("\n\t Presione una tecla para continuar...");
                        Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                        break;
                }
            }
            while (op != 3);
        }

    }
}
