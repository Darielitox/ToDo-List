// Gestión de Tareas (To-Do List) 
// Objetivo: Manejo de arreglos, menús y control de flujo. 
// Desarrolla un sistema que permita gestionar tareas. 
// Debe permitir: 
// - Agregar tarea 
// - Ver todas las tareas 
// - Eliminar una tarea (por posición o nombre) 
// - Salir 
// Condiciones: 
// - No se permiten datos fijos 
// - Debe poder agregar múltiples tareas 
// - Validar cuando no existan tareas

using System;
using System.IO;
using System.Net;
using System.Threading;

namespace ToDo_List
{
    
    class Program
    {   
        private static string archivoTareas = "Tareas.txt";
        static void Main(string[] args)
        {
            if (!File.Exists(archivoTareas))
            {
                File.WriteAllText(archivoTareas, "");
            }

            string[] tareas = File.ReadAllLines(archivoTareas);

            bool salida = false;
            do
            {
                Console.Clear();
                Console.WriteLine(@"
 ████████╗ ██████╗ ██████╗  ██████╗     ██╗     ██╗███████╗████████╗
 ╚══██╔══╝██╔═══██╗██╔══██╗██╔═══██╗    ██║     ██║██╔════╝╚══██╔══╝
    ██║   ██║   ██║██║  ██║██║   ██║    ██║     ██║███████╗   ██║   
    ██║   ██║   ██║██║  ██║██║   ██║    ██║     ██║╚════██║   ██║   
    ██║   ╚██████╔╝██████╔╝╚██████╔╝    ███████╗██║███████║   ██║   
    ╚═╝    ╚═════╝ ╚═════╝  ╚═════╝     ╚══════╝╚═╝╚══════╝   ╚═╝   ");
                Console.WriteLine("=======================================================================\n");
                if (tareas.Length < 1)
                {
                    Console.WriteLine("\tNo exiten tareas");
                }
                else
                {
                    for (int i = 0; i < tareas.Length; i++)
                    {
                        Console.WriteLine($"\t{i + 1} - {tareas[i]}");
                    }
                }
                Console.WriteLine("\n=======================================================================\n");
                Console.WriteLine(" 1 - AGREGAR TAREA");
                Console.WriteLine(" 2 - ELIMINAR TAREA");
                Console.WriteLine(" 3 - SALIR");
                Console.Write("\nElija una opcion: ");

                string opcion = Console.ReadLine()!;

                switch (opcion)
                {
                    case "1":
                        tareas = AgregarTarea(tareas);
                    break;

                    case "2":
                        tareas = EliminarTarea(tareas);
                    break;

                    case "3":
                        salida = true;
                        Console.WriteLine("Saliendo.....");
                        Thread.Sleep(500);
                        Console.Clear();
                    break;

                    default:
                        Console.WriteLine("Opcion invalida, vuelva a intentar");
                        Thread.Sleep(1000);
                    break;
                }

            } while (!salida);
        }
        static string[] AgregarTarea(string[] tareas)
        {
            do
            {
                Console.Clear();
                Console.Write("Ingrese la tarea: ");
                string tareaIngresada = Console.ReadLine()!;
                if (tareaIngresada.IsWhiteSpace())
                {
                    Console.WriteLine("Error, la tarea no puede estar vacia");
                    Thread.Sleep(600);
                    continue;
                }
                else
                {
                    string[] arrayTemporal = new string[tareas.Length + 1];
                    for (int i = 0; i < tareas.Length; i++)
                    {
                        arrayTemporal[i] = tareas[i];
                    }
                    arrayTemporal[arrayTemporal.Length - 1] = tareaIngresada;
                    CargarTareas(arrayTemporal);
                    return arrayTemporal;
                }
            } while (true);
        }
        static void CargarTareas(string[] tareas)
        {
            File.WriteAllLines(archivoTareas, tareas);
        }

        static string[] EliminarTarea(string[] tareas)
        {
            do
            {
                Console.Clear();
                if (tareas.Length < 1)
                {
                    Console.WriteLine("\tNo exiten tareas");
                }
                else
                {
                    for (int i = 0; i < tareas.Length; i++)
                    {
                        Console.WriteLine($"\t{i + 1} - {tareas[i]}");
                    }
                }
                Console.WriteLine("\n---------------------------------\n");
                if (tareas.Length == 0)
                {
                    Console.WriteLine("No hay tareas para eliminar.");
                    Thread.Sleep(1000);
                    return tareas;
                }

                Console.Write("Ingrese un el numero de la tarea a eliminar: ");
                if (int.TryParse(Console.ReadLine()!, out int indiceEliminado))
                {
                    indiceEliminado = indiceEliminado - 1;
                    if (indiceEliminado >= 0 && indiceEliminado < tareas.Length)
                    {
                        string[] arrayTemporal = new string[tareas.Length - 1];
                        int j = 0;

                        for (int i = 0; i < tareas.Length; i++)
                        {
                            if (i != indiceEliminado)
                            {
                                arrayTemporal[j] = tareas[i];
                                j++;
                            }
                        }
                    
                        Console.WriteLine("Tarea eliminada.");
                        Thread.Sleep(600);
                        CargarTareas(arrayTemporal);
                        return arrayTemporal;
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un numero");
                    Thread.Sleep(500);
                    continue;
                }

                
                Console.WriteLine("Indice invalido, elemento seleccionado no se encuentra en la lista");
                Thread.Sleep(600);
                return tareas;
                
            } while (true);
        }
    }
}