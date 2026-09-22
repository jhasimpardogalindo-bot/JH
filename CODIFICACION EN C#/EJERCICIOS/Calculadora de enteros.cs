using System;
using System.Collections.Generic;
using System.Text;

namespace CODIFICACION_EN_C_.EJERCICIOS
{
    internal class Calculadora_de_enteros
    {
        Console.Write("Primer número: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Operación (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Segundo número: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        if (op == '+') resultado = a + b;
        else if (op == '-') resultado = a - b;

    }
}

















Console.Write("Primer número: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Operación (+, -, *, /): ");
char op = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.Write("Segundo número: ");
double b = Convert.ToDouble(Console.ReadLine());

double resultado = 0;

if (op == '+') resultado = a + b;
else if (op == '-') resultado = a - b;











