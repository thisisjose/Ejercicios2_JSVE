using Ejercicios2_JSVE.Clases;
using System;

namespace Ejercicios2_JSVE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //int[] resultado = Clases.metodos.SumaDeArreglos();
            //Console.WriteLine("Resultado de la suma:");
            //for (int i = 0; i < resultado.Length; i++)
            //{
            //    Console.Write(resultado[i] + " ");
            //}

            //metodos metodos1 = new metodos();

            //Console.WriteLine("Ingrese el tmañaño:");

            //int tamañoA = int.Parse(Console.ReadLine());

            //int[] arreglo = new int[tamañoA];

            //for (int i = 0; i < tamañoA; i++)
            //{
            //    Console.Write($"Ingrese el valor {i + 1}: ");
            //    arreglo[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Ingrese el elemento a buscar:");
            //int elementoBuscado = int.Parse(Console.ReadLine());

            //int[] coincidencia = metodos1.BuscarPosicionElemento(arreglo, elementoBuscado);

            //Console.WriteLine("Posiciones de coincidencia:");
            //foreach (int posicion in coincidencia)
            //{
            //    Console.WriteLine($"Posición: {posicion}");
            //}



            //metodos metodos1 = new metodos();

            //int[] idsAlgebra = metodos1.ObtenerIDs("Álgebra");
            //int[] idsAnalisis = metodos1.ObtenerIDs("Análisis");

            //int[] alumnosComunes = metodos1.EncontrarAlumnosComunes(idsAlgebra, idsAnalisis);

            //metodos1.MostrarAlumnos(idsAlgebra, "Alumnos inscritos en Álgebra:");
            //metodos1.MostrarAlumnos(idsAnalisis, "Alumnos inscritos en Análisis:");
            //metodos1.MostrarAlumnos(alumnosComunes, "Alumnos inscritos en ambas clases:");

            //Console.WriteLine($"Número de alumnos que se repiten: {alumnosComunes.Length}");


            //metodos metodos1 = new metodos();

            //int[] arreglo = metodos1.LlenarArreglo();

            //Console.WriteLine("Contenido del arreglo:");
            //foreach (int elemento in arreglo)
            //{
            //    Console.WriteLine(elemento);
            //}

            //Console.ReadKey();

            Console.WriteLine("Ingrese la cantidad de notas:");
            int cantidadNotas = Convert.ToInt32(Console.ReadLine());
            int[] notas = new int[cantidadNotas];

            for (int i = 0; i < cantidadNotas; i++)
            {
                Console.Write($"Ingrese la nota {i + 1}: ");
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            metodos metodos1 = new metodos();
            metodos1.CalcularPromedioYContar(notas);

            Console.ReadKey();
        }
    }
}