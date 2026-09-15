using System;
using System.Collections.Generic;
using System.Text;

namespace EJER.ejercicios
{
    internal class EJ03_EST28
    {
        public static void Main(string[] args)
            {
                // Los límites mínimo y máximo deben ser constantes obligatoriamente
                const int MIN_TONELADAS = 1;
                const int MAX_TONELADAS = 500;

                int toneladas;

                // Usar do-while para que el dato se pida al menos una vez
                do
                {
                    Console.Write("Ingrese el valor de toneladas de carbonato de litio producidas: ");
                    toneladas = int.Parse(Console.ReadLine());

                    // Usar un if dentro del ciclo para mostrar el mensaje de error si está fuera de rango
                    if (toneladas < MIN_TONELADAS || toneladas > MAX_TONELADAS)
                    {
                        Console.WriteLine("Error: El valor debe estar dentro del rango permitido de " + MIN_TONELADAS + " a " + MAX_TONELADAS + " toneladas.");
                    }

                }
                // La condición del ciclo debe repetir mientras el valor esté fuera del rango
                while (toneladas < MIN_TONELADAS || toneladas > MAX_TONELADAS);

                Console.WriteLine("¡Dato válido registrado con éxito: " + toneladas + " toneladas!");
            }
        }
    }