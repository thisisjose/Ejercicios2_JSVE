using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2_JSVE.Clases
{
    internal class metodos
    {
        //public static int[] SumaDeArreglos()
        //{
        //    Console.WriteLine("Escribir el tamaño:");
        //    int tamaño = Convert.ToInt32(Console.ReadLine());
        //    int[] a1 = new int[tamaño];
        //    int[] a2 = new int[tamaño];
        //    int[] resultado = new int[tamaño];

        //    Console.WriteLine("Arreglo1:");
        //    for (int x = 0; x < tamaño; x++)
        //    {
        //        Console.WriteLine($"valor{x + 1}:");
        //        arreglo1[x] = int.Parse(Console.ReadLine());
        //    }
        //    Console.WriteLine("Arreglo2:");
        //    for (int x = 0; x < tamaño; x++)
        //    {
        //        Console.WriteLine($"valor{x + 1}:");
        //        arreglo2[x] = int.Parse(Console.ReadLine());
        //    }

        //    for (int x = 0; x < tamaño; x++)
        //    {
        //        resultado[x] = a1[x] + a2[x];
        //    }
        //    return resultado;
        //}

        //N2
        //public void ValorArreglo(int[] arreglo)
        //{
        //    foreach (int valor in arreglo)
        //    {
        //        Console.Write(valor + " ");
        //    }
        //    Console.WriteLine();
        //}

        //public int[] BuscarPosicionElemento(int[] arreglo, int elementoBuscado)
        //{
        //    int contadorCoincidencia = 0;
        //    for (int i = 0; i < arreglo.Length; i++)
        //    {
        //        if (arreglo[i] == elementoBuscado)
        //        {
        //            contadorCoincidencia++;
        //        }
        //    }

        //    int[] posicionesCoincidencia = new int[contadorCoincidencia];
        //    contadorCoincidencia = 0;

        //    for (int i = 0; i < arreglo.Length; i++)
        //    {
        //        if (arreglo[i] == elementoBuscado)
        //        {
        //            posicionesCoincidencia[contadorCoincidencia] = i;
        //            contadorCoincidencia++;
        //        }
        //    }

        //    return posicionesCoincidencia;
        //}

        //N3
        //public int[] ObtenerIDs(string nombreClase)
        //{
        //    Console.WriteLine($"Ingrese la cantidad de alumnos en la clase de {nombreClase}:");
        //    int cantidadAlumnos = Convert.ToInt32(Console.ReadLine());

        //    int[] idsClase = new int[cantidadAlumnos];

        //    for (int i = 0; i < cantidadAlumnos; i++)
        //    {
        //        Console.Write($"Ingrese el ID del alumno {i + 1} en {nombreClase}: ");
        //        idsClase[i] = Convert.ToInt32(Console.ReadLine());
        //    }

        //    return idsClase;
        //}

        //public int[] EncontrarAlumnosComunes(int[] arreglo1, int[] arreglo2)
        //{
        //    var alumnosComunes = arreglo1.Intersect(arreglo2).ToArray();
        //    return alumnosComunes;
        //}

        //public void MostrarAlumnos(int[] ids, string mensaje)
        //{
        //    Console.WriteLine(mensaje);
        //    foreach (int id in ids)
        //    {
        //        Console.WriteLine($"ID del alumno: {id}");
        //    }
        //}

        //public int[] LlenarArreglo()
        //{
        //    Console.WriteLine("Ingrese el tamaño del arreglo:");
        //    int tamaño = int.Parse(Console.ReadLine());

        //    int[] arreglo = new int[tamaño];
        //    int indice = 0;

        //    while (indice < tamaño)
        //    {
        //        Console.Write($"Ingrese el valor {indice + 1}: ");
        //        int valor = int.Parse(Console.ReadLine());

        //        if (!ContieneValor(arreglo, valor, indice))
        //        {
        //            arreglo[indice] = valor;
        //            indice++;
        //        }
        //        else
        //        {
        //            Console.WriteLine("El valor ya existe en el arreglo. Ingrese otro valor.");
        //        }
        //    }

        //    return arreglo;
        //}

        //private bool ContieneValor(int[] arreglo, int valor, int limite)
        //{
        //    for (int i = 0; i < limite; i++)
        //    {
        //        if (arreglo[i] == valor)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public void CalcularPromedioYContar(int[] notas)
        {
            int aprobadas = 0;
            int desaprobadas = 0;
            int sumaAprobadas = 0;
            int sumaDesaprobadas = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= 8 && notas[i] <= 20)
                {
                    aprobadas++;
                    sumaAprobadas += notas[i];
                }
                else if (notas[i] >= 0 && notas[i] <= 5)
                {
                    desaprobadas++;
                    sumaDesaprobadas += notas[i];
                }
            }

            double promedioAprobadas = aprobadas > 0 ? (double)sumaAprobadas / aprobadas : 0;
            double promedioDesaprobadas = desaprobadas > 0 ? (double)sumaDesaprobadas / desaprobadas : 0;

            Console.WriteLine($"Promedio de notas aprobadas: {promedioAprobadas}");
            Console.WriteLine($"Promedio de notas desaprobadas: {promedioDesaprobadas}");
            Console.WriteLine($"Cantidad de notas aprobadas: {aprobadas}");
            Console.WriteLine($"Cantidad de notas desaprobadas: {desaprobadas}");
        }
    }
}

   
