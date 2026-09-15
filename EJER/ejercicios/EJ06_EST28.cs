using System;
using System.Collections.Generic;
using System.Text;

namespace EJER.ejercicios
{
    internal class EJ06_EST28
    {
        public static void Main(string[] args)
        {
            // Reserva inicial de documentos
            int reserva = 3000;

            // Cantidad fija que se entrega cada jornada (puedes ajustarla o pedirla por teclado)
            int entregaPorJornada = 250;

            // Contador para saber cuántas jornadas duró la reserva
            int jornadas = 0;

            // Cálculo del límite del 20% de la reserva total inicial para la alerta
            double limiteAlerta = 3000 * 0.20;

            // Usar un ciclo while que se repita mientras la reserva sea mayor que cero
            while (reserva > 0)
            {
                // Descontar la entrega dentro del ciclo (la reserva debe disminuir)
                reserva -= entregaPorJornada;

                // Incrementar el contador de jornadas
                jornadas++;

                // Control por si la reserva queda en negativo tras la última resta
                if (reserva < 0)
                {
                    reserva = 0;
                }

                // Mostrar en cada vuelta cuanto queda
                Console.WriteLine("Jornada " + jornadas + " - Documentos restantes en reserva: " + reserva);

                // Usar un if para la alerta de reserva baja (cuando baje del 20%)
                if (reserva <= limiteAlerta && reserva > 0)
                {
                    Console.WriteLine("¡ALERTA! La reserva ha bajado del 20% del total.");
                }
            }

            // Contar y mostrar cuántas jornadas duró la reserva
            Console.WriteLine("\nLa reserva se agotó por completo.");
            Console.WriteLine("Total de jornadas que duró la reserva: " + jornadas);
        }
    }
}
}
