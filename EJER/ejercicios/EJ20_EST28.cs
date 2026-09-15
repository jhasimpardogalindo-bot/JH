using System;
using System.Collections.Generic;
using System.Text;

namespace EJER.ejercicios
{
    internal class EJ20_EST28
    {
    static void Main(string[] args)
        {
            // Todos los umbrales y límites deben ser constantes
            const int MIN_VALOR = 0;
            const int MAX_VALOR = 200;
            const int TOTAL_COMUNIDADES = 3;
            const int RACION_ENTREGA = 50;
            const double UMBRAL_ALTO = 130.0;
            const double UMBRAL_MEDIO = 70.0;

            // Variables de estado y acumuladores
            int opcion;
            int totalFamilias = 0;
            int comunidadesCargadas = 0;

            // Menú principal con do while y escalera if / else if / else
            do
            {
                Console.WriteLine("\n--- SISTEMA FONDO NACIONAL DE INVERSION PRODUCTIVA Y SOCIAL (FPS) ---");
                Console.WriteLine("1) Carga de comunidades");
                Console.WriteLine("2) Reporte de clasificacion");
                Console.WriteLine("3) Simulacion de cobertura");
                Console.WriteLine("4) Salir");
                Console.Write("Elija una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    // La opción 1 combina un for con un do while de validación anidado dentro
                    totalFamilias = 0; // Reiniciar o acumular segun se requiera
                    comunidadesCargadas = 0;

                    for (int i = 1; i <= TOTAL_COMUNIDADES; i++)
                    {
                        int familiasValidas;

                        // Do while para validar cada valor en el rango 0 a 200
                        do
                        {
                            Console.Write("Ingrese las familias cubiertas en la comunidad " + i + " (0 a 200): ");
                            familiasValidas = int.Parse(Console.ReadLine());

                            if (familiasValidas < MIN_VALOR || familiasValidas > MAX_VALOR)
                            {
                                Console.WriteLine("Error: El valor debe estar entre " + MIN_VALOR + " y " + MAX_VALOR + ".");
                            }

                        } while (familiasValidas < MIN_VALOR || familiasValidas > MAX_VALOR);

                        // Acumula el total
                        totalFamilias += familiasValidas;
                        comunidadesCargadas++;
                    }

                    Console.WriteLine("¡Carga de comunidades completada con éxito!");
                }
                else if (opcion == 2)
                {
                    // La opción 2 debe protegerse con un if: no clasificar si no hay datos cargados
                    if (comunidadesCargadas > 0)
                    {
                        double promedio = (double)totalFamilias / TOTAL_COMUNIDADES;
                        Console.WriteLine("\nPromedio de familias cubiertas: " + promedio);

                        // Clasificación con escalera if / else if / else
                        if (promedio >= UMBRAL_ALTO)
                        {
                            Console.WriteLine("Clasificación: COBERTURA ALTA");
                        }
                        else if (promedio >= UMBRAL_MEDIO)
                        {
                            Console.WriteLine("Clasificación: COBERTURA MEDIA");
                        }
                        else
                        {
                            Console.WriteLine("Clasificación: COBERTURA BAJA");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Aviso: No se puede generar el reporte porque aún no se han cargado datos.");
                    }
                }
                else if (opcion == 3)
                {
                    // La opción 3 protege verificar si hay datos para simular
                    if (comunidadesCargadas > 0)
                    {
                        // La opción 3 usa un ciclo while de descuento
                        int saldoRestante = totalFamilias;
                        int jornadas = 0;

                        Console.WriteLine("\n--- INICIO DE SIMULACIÓN DE COBERTURA ---");
                        while (saldoRestante > 0)
                        {
                            saldoRestante -= RACION_ENTREGA;
                            jornadas++;
                        }

                        // Informa cuantas jornadas cubre
                        Console.WriteLine("Total de familias cargadas: " + totalFamilias);
                        Console.WriteLine("Cantidad de jornadas cubiertas (en entregas de 50): " + jornadas);
                    }
                    else
                    {
                        Console.WriteLine("Aviso: Debe cargar los datos de las comunidades primero para realizar la simulación.");
                    }
                }
                else if (opcion == 4)
                {
                    // Salir, que muestra el resumen general de la sesión
                    Console.WriteLine("\nSaliendo del sistema...");
                }
                else
                {
                    Console.WriteLine("Error: Opción inválida. Intente de nuevo.");
                }

            } while (opcion != 4);

            // Resumen general de la sesión al salir
            Console.WriteLine("\n========================================");
            Console.WriteLine("RESUMEN GENERAL DE LA SESIÓN");
            Console.WriteLine("Comunidades cargadas: " + comunidadesCargadas);
            Console.WriteLine("Total acumulado de familias cubiertas: " + totalFamilias);
            Console.WriteLine("Programa finalizado correctamente.");
        }
    }
}