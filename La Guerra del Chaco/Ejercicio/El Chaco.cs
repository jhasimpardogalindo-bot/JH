using System;
using System.Collections.Generic;
using System.Text;

namespace La_Guerra_del_Chaco.Ejercicio
{
    internal class El_Chaco
    {
    }

    class Program
    {
        public static void Main()
        {
            int distancia = 50; // Kilómetros restantes
            int agua = 50;      // Litros restantes
            int dia = 1;

            Console.WriteLine("=== GUERRA DEL CHACO: EXPEDICIÓN POR AGUA ===");

            // Bucle do-while: se ejecuta mientras haya camino y reservas de agua
            do
            {
                Console.WriteLine($"\n--- DÍA {dia} ---");
                Console.WriteLine($"Distancia al pozo: {distancia} km | Agua: {agua} L");
                Console.WriteLine("1. Marcha rápida (-20 km, -20 L)");
                Console.WriteLine("2. Marcha normal (-10 km, -10 L)");
                Console.WriteLine("3. Buscar agua   (0 km, +15 L)");
                Console.Write("Elige tu orden (1, 2 o 3): ");

                string decision = Console.ReadLine();

                // Estructura if - else if - else para evaluar la decisión
                if (decision == "1")
                {
                    distancia -= 20;
                    agua -= 20;
                    Console.WriteLine("La tropa avanzó rápido bajo el sol abrasador.");
                }
                else if (decision == "2")
                {
                    distancia -= 10;
                    agua -= 10;
                    Console.WriteLine("Avanzaron a paso firme y con precaución.");
                }
                else if (decision == "3")
                {
                    agua += 15;
                    Console.WriteLine("Encontraron plantas caraguatas y obtuvieron agua.");
                }
                else
                {
                    Console.WriteLine("Orden no entendida. La patrulla perdió tiempo.");
                    agua -= 5;
                }

                dia++;

            } while (distancia > 0 && agua > 0);

            // Evaluación final de la misión
            Console.WriteLine("\n==============================");
            if (distancia <= 0)
            {
                Console.WriteLine("¡MISIÓN CUMPLIDA! Llegaron al pozo y salvaron a la patrulla.");
            }
            else
            {
                Console.WriteLine("MISIÓN FALLIDA. Se terminó el agua antes de llegar.");
            }
        }
    }
}