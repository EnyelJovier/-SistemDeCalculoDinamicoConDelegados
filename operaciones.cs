using System;

namespace Operaciones_Delegados
{
    public class Operaciones
    {
        // Delegado
        public delegate double Operacion(double a, double b);

        // Métodos
        public static double Sumar(double a, double b)
        {
            return a + b;
        }

        public static double Restar(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: no se puede dividir entre 0");
                return 0;
            }

            return a / b;
        }
    }
}
