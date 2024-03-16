using System;

namespace ClaseDeHoy
{
    class Program
    {
        static void ejemplo1()
        {
            int[] calificaciones;
            calificaciones = new int[] { 85, 77, 68, 94, 75 };
            Console.WriteLine(calificaciones[1]);
        }

        static void ejemplo2()
        {
            string[] nombres = new string[3];
            nombres[0] = "Juan";
            nombres[1] = "Ana";
            nombres[2] = "Pedro";

            foreach (string nombre in nombres)
            {
                Console.WriteLine("Nombre=" + nombre);
            }
        }

        static void promedio()
        {
            int[] notas = { 80, 75, 90, 95, 73, 79 };
            int suma = 0;

            foreach (int nota in notas)
            {
                suma = suma + nota;
            }
            Console.WriteLine("Promedio = " + (suma / notas.Length));

            //Ahora con for
            int sumas = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                sumas = sumas + notas[i];
            }
            Console.WriteLine("Promedio = " + (sumas / notas.Length));
        }

        static void Arreglo()
        {
            string[] Original = { "Juan", "Ana", "Pedro", "Maria", "Andrea" };
            string[] Invertido = new string[Original.Length];

            for (int i = 0; i < Original.Length; i++)
            {
                Invertido[i] = Original[Original.Length - 1 - i];
            }

            foreach (var elemento in Invertido)
            {
                Console.Write(elemento + " ");
            }
        }

        static void Main(string[] args)
        {
        }

        static void prom()
        {
            int[] notas = { 80, 75, 90, 95, 73, 79, 90, 34 };
            int[] n2 = new int[notas.Length];

            int i = notas.Length - 1;
            foreach (int nota in notas)
            {
                n2[i] = nota;
                Console.WriteLine(n2[i]);
                i--;
            }
        }
    }
}