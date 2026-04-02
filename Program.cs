using System;
using System.Collections.Generic;

namespace Operaciones_Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diccionario con operaciones
            Dictionary<int, Operaciones.Operacion> operaciones = new Dictionary<int, Operaciones.Operacion>()
            {
                {1, Operaciones.Sumar},
                {2, Operaciones.Restar},
                {3, Operaciones.Multiplicar},
                {4, Operaciones.Dividir}
            };

            Console.WriteLine(" OPERACIONES CON DELEGADOS ");

            Console.Write("Ingrese el primer numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSeleccione el tipo de operacion:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");

            Console.Write("Opcion :");
            int opcion = Convert.ToInt32(Console.ReadLine());

            // Uso del delegado
            Operaciones.Operacion op = operaciones[opcion];

            double resultado = op(num1, num2);

            Console.WriteLine("\nResultado: " + resultado);

            Console.ReadKey();
        }
    }
}