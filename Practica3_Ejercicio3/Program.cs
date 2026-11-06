namespace Practica3_Ejercicio3
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros =
            {
            { 9, 8, 7 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int suma = 0;

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    suma = suma + numeros[fila, columna];
                }
            }

            Console.WriteLine("La suma de los números es: " + suma);
        }
    }
}
