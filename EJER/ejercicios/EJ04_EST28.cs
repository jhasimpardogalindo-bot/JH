using System;
using System.Collections.Generic;
using System.Text;

namespace EJER.ejercicios
{
    internal class EJ04_EST28
    {
        public static void Main(string[] args)
        {
            // Los textos fijos del menú declarados como constantes obligatorias
            const string MENU_TITULO = "\n--- MENU DE CONSULTAS ENDE ---";
            const string OPCION_1 = "1) Ver el registro de comunidades con paneles";
            const string OPCION_2 = "2) Ver la meta del periodo";
            const string OPCION_3 = "3) Ver el rango valido de kilovatios hora generados en el mes";
            const string OPCION_4 = "4) Salir";
            const string SOLICITAR_OPCION = "Elija una opcion: ";

            int opcion;

            // Usar do while para repetir el menú hasta que la opción sea 4
            do
            {
                // Mostrar los textos fijos definidos en constantes
                Console.WriteLine(MENU_TITULO);
                Console.WriteLine(OPCION_1);
                Console.WriteLine(OPCION_2);
                Console.WriteLine(OPCION_3);
                Console.WriteLine(OPCION_4);
                Console.Write(SOLICITAR_OPCION);

                opcion = int.Parse(Console.ReadLine());

                // Usar una escalera if / else if / else para atender cada opción
                if (opcion == 1)
                {
                    Console.WriteLine("Mostrando el registro de comunidades con paneles fotovoltaicos.");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Mostrando la meta de generación del periodo.");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Mostrando el rango válido de kilovatios hora generados en el mes.");
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Saliendo del programa de consultas...");
                }
                else
                {
                    // El else final atiende las opciones inválidas
                    Console.WriteLine("Error: La opción no existe. Por favor, intente de nuevo.");
                }

            } while (opcion != 4);
        }
    }
}
