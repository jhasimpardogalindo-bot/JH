using System;
using System.Collections.Generic;
using System.Text;

namespace EJER.ejercicios
{
    public class EJ02_EST28
    {
        public static void Main(string[] args)
        {
            const int META = 600; // Meta constante
            int i = 1, suma = 0;   // Inicialización de contador y acumulador en cero

            // Ciclo while para pedir los 9 valores
            while (i <= 9)
            {
                Console.Write($"Minutos trámite {i}: ");
                suma += int.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine($"Total acumulado: {suma}");

            // Comparación con if / else al terminar el ciclo
            if (suma >= META)
                Console.WriteLine("Alcanzó la meta de 600 minutos.");
            else
                Console.WriteLine("No alcanzó la meta.");
        }
    }
}
