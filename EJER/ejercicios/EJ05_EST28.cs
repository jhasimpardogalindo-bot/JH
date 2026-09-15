using System;
using System.Collections.Generic;
using System.Text;

namespace EJER.ejercicios
{
    internal class EJ05_EST28
    {
        public static void Main(string[] args)
        {
            // Constante para el umbral de intentos de intrusión
            const int UMBRAL = 200;

            // Contadores independientes para los que cumplen y los que no (parten de cero)
            int cumple = 0;
            int noCumple = 0;

            // Ciclo for obligatorio que va de 1 hasta 9 (recorre los 9 incidentes)
            for (int i = 1; i <= 9; i++)
            {
                Console.Write("Ingrese los intentos de intrusión detectados en el incidente " + i + ": ");
                int intentos = int.Parse(Console.ReadLine());

                // Usar if / else dentro del ciclo para decidir si cumple con el umbral
                if (intentos >= UMBRAL)
                {
                    Console.WriteLine("Incidente " + i + ": CUMPLE (supera o iguala el umbral)");
                    cumple++;
                }
                else
                {
                    Console.WriteLine("Incidente " + i + ": NO CUMPLE (por debajo del umbral)");
                    noCumple++;
                }
            }

            // Mostrar el resumen recién cuando el ciclo termina
            Console.WriteLine("\n--- RESUMEN FINAL ---");
            Console.WriteLine("Total de incidentes que cumplen el umbral: " + cumple);
            Console.WriteLine("Total de incidentes que no cumplen el umbral: " + noCumple);
        }
    }
}
}
