using System;
using System.Collections.Generic;
using System.Text;

namespace EJER.ejercicios
{
    public class EJ01_EST28
    {
        public static void Main(string[] args)
        {
            {
                const int TOTAL_CURSOS = 7;
                int i = 1;

                while (i <= TOTAL_CURSOS)
                {
                    Console.WriteLine("Asignatura originaria registrado Nro: " + i);
                    i++; // <- Esto es lo que faltaba para evitar el bucle infinito
                }

                Console.WriteLine("Total de cursos procesados: " + TOTAL_CURSOS);
            }
        }
    }
}