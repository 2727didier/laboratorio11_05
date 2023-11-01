using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio11_05
{
    internal class Program
 
        {
            static double[] notas;
            static int cantidadNotas = 0;

            static void Main(string[] args)
            {
                MostrarMenu();
            }

            static void MostrarMenu()
            {
                notas = new double[100]; // Puedes ajustar el tamaño del arreglo según tus necesidades

                while (true)
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("Casos con arreglos");
                    Console.WriteLine("================================");
                    Console.WriteLine("1: Registrar notas");
                    Console.WriteLine("2: Hallar la nota mayor");
                    Console.WriteLine("3: Hallar la nota menor");
                    Console.WriteLine("4: Encontrar una nota");
                    Console.WriteLine("5: Modificar una nota");
                    Console.WriteLine("6: Ver notas registradas");
                    Console.WriteLine("7: Salir");
                    Console.WriteLine("================================");

                    Console.Write("Ingrese una opción: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            RegistrarNotas();
                            break;
                        case 2:
                            MostrarNotaMayor();
                            break;
                        case 3:
                            MostrarNotaMenor();
                            break;
                        case 4:
                            BuscarNota();
                            break;
                        case 5:
                            ModificarNota();
                            break;
                        case 6:
                            VerNotasRegistradas();
                            break;
                        case 7:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
                            break;
                    }
                }
            }

            static void RegistrarNotas()
            {
                int opcion;
                do
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("Registrar una nota");
                    Console.WriteLine("================================");
                    Console.Write($"Ingresa la nota Nro {cantidadNotas + 1}: ");
                    notas[cantidadNotas] = Convert.ToDouble(Console.ReadLine());
                    cantidadNotas++;

                    Console.WriteLine("================================");
                    Console.WriteLine("1: Registrar otra nota");
                    Console.WriteLine("2: Regresar");
                    Console.Write("Ingrese una opción: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                } while (opcion == 1);
            }

            static void MostrarNotaMayor()
            {
                if (cantidadNotas > 0)
                {
                    double maxNota = notas[0];
                    for (int i = 1; i < cantidadNotas; i++)
                    {
                        if (notas[i] > maxNota)
                        {
                            maxNota = notas[i];
                        }
                    }

                    Console.WriteLine("================================");
                    Console.WriteLine("La nota mayor");
                    Console.WriteLine("================================");
                    Console.WriteLine("La nota mayor es: " + maxNota);
                    MostrarNotasRegistradas();
                }
                else
                {
                    Console.WriteLine("No se han registrado notas aún.");
                }

                Console.WriteLine("================================");
                Console.WriteLine("1: Regresar");
                Console.Write("Ingrese una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
            }

            static void MostrarNotaMenor()
            {
                if (cantidadNotas > 0)
                {
                    double minNota = notas[0];
                    for (int i = 1; i < cantidadNotas; i++)
                    {
                        if (notas[i] < minNota)
                        {
                            minNota = notas[i];
                        }
                    }

                    Console.WriteLine("================================");
                    Console.WriteLine("La nota menor");
                    Console.WriteLine("================================");
                    Console.WriteLine("La nota menor es: " + minNota);
                    MostrarNotasRegistradas();
                }
                else
                {
                    Console.WriteLine("No se han registrado notas aún.");
                }

                Console.WriteLine("================================");
                Console.WriteLine("1: Regresar");
                Console.Write("Ingrese una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
            }

            static void BuscarNota()
            {
                Console.WriteLine("================================");
                Console.WriteLine("Buscar nota");
                Console.WriteLine("================================");
                Console.Write("Ingrese la nota a buscar: ");
                double notaBuscada = Convert.ToDouble(Console.ReadLine());
                bool encontrada = false;

                for (int i = 0; i < cantidadNotas; i++)
                {
                    if (notas[i] == notaBuscada)
                    {
                        Console.WriteLine("La nota está en la posición {0}", i);
                        encontrada = true;
                        break;
                    }
                }

                if (!encontrada)
                {
                    Console.WriteLine("La nota no se encuentra en el arreglo.");
                }

                MostrarNotasRegistradas();

                Console.WriteLine("================================");
                Console.WriteLine("1: Regresar");
                Console.Write("Ingrese una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
            }

            static void ModificarNota()
            {
                if (cantidadNotas > 0)
                {
                    Console.Write("Ingrese la posición de la nota que desea modificar: ");
                    int posicion = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (posicion >= 0 && posicion < cantidadNotas)
                    {
                        Console.Write("Ingrese la nueva nota: ");
                        notas[posicion] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La nota ha sido modificada exitosamente.");
                        MostrarNotasRegistradas();
                    }
                    else
                    {
                        Console.WriteLine("La posición ingresada no es válida.");
                    }
                }
                else
                {
                    Console.WriteLine("No se han registrado notas aún.");
                }

                Console.WriteLine("================================");
                Console.WriteLine("1: Regresar");
                Console.Write("Ingrese una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
            }

            static void VerNotasRegistradas()
            {
                MostrarNotasRegistradas();

                Console.WriteLine("================================");
                Console.WriteLine("1: Regresar");
                Console.Write("Ingrese una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
            }

            static void MostrarNotasRegistradas()
            {
                Console.WriteLine("Notas registradas:");
                for (int i = 0; i < cantidadNotas; i++)
                {
                    if (i == cantidadNotas - 1)
                        Console.Write($"{i} -> {notas[i]}");
                    else
                {
                    string v = $"{i} -> (notas[i)";
                    string valor = v;
                    Console.WriteLine(valor);
                }
            }
            }
    }

 }


