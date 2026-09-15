using System;
using System.Collections.Generic;
using System.Text;

namespace EJER.ejercicios
{
    internal class EJ09_EST28
    {
        public static void Main(string[] args)
        {
            // Los umbrales deben ser constantes, sin números sueltos en el código
            const int UMBRAL_ALTO = 180;
            const int UMBRAL_MEDIO = 80;
            const int TOTAL_PARTES = 7;

            // Llevar un contador por cada una de las tres categorías (parten de cero)
            int contadorAlta = 0;
            int contadorMedia = 0;
            int contadorBaja = 0;

            // Usar un ciclo for para los 7 partes de guerra
            for (int i = 1; i <= TOTAL_PARTES; i++)
            {
                Console.Write("Ingrese el valor del parte de guerra " + i + ": ");
                int valorParte = int.Parse(Console.ReadLine());

                // Usar la escalera if / else if / else ordenada de mayor a menor
                if (valorParte >= UMBRAL_ALTO)
                {
                    Console.WriteLine("Parte " + i + ": CLASIFICACION ALTA");
                    contadorAlta++;
                }
                else if (valorParte >= UMBRAL_MEDIO)
                {
                    Console.WriteLine("Parte " + i + ": CLASIFICACION MEDIA");
                    contadorMedia++;
                }
                else
                {
                    Console.WriteLine("Parte " + i + ": CLASIFICACION BAJA");
                    contadorBaja++;
                }
            }

            // Mostrar el resumen al final indicando cuántos cayeron en cada categoría
            Console.WriteLine("\n--- RESUMEN FINAL ---");
            Console.WriteLine("Total con Clasificación Alta: " + contadorAlta);
            Console.WriteLine("Total con Clasificación Media: " + contadorMedia);
            Console.WriteLine("Total con Clasificación Baja: " + contadorBaja);
        }
    }
}
}
