using System;
using System.Collections.Generic;
using System.Text;

namespace EJER.ejercicios
{
    internal class EJ08_EST28
    {
        public static void Main(string[] args)
        {
            // Contador para el ciclo while que llegue hasta 9
            int i = 1;

            // Contadores independientes para pares e impares (parten de cero)
            int contadorPares = 0;
            int contadorImpares = 0;

            // Usar while con un contador que llegue hasta 9
            while (i <= 9)
            {
                Console.Write("Ingrese el número del documento " + i + ": ");
                int numeroDoc = int.Parse(Console.ReadLine());

                // Usar if / else con la condición numero % 2 == 0
                if (numeroDoc % 2 == 0)
                {
                    Console.WriteLine("Documento " + numeroDoc + ": Turno de maÑana (Par)");
                    contadorPares++; // Llevar un contador de pares
                }
                else
                {
                    Console.WriteLine("Documento " + numeroDoc + ": Turno de tarde (Impar)");
                    contadorImpares++; // Llevar un contador de impares
                }

                // Actualización del contador del ciclo
                i++;
            }

            // Mostrar el resumen de ambos turnos al final
            Console.WriteLine("\n--- RESUMEN FINAL ---");
            Console.WriteLine("Total de documentos en el turno de mañana (Pares): " + contadorPares);
            Console.WriteLine("Total de documentos en el turno de tarde (Impares): " + contadorImpares);
        }
    }
}
}
