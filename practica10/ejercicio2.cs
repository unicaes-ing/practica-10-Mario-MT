using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    class ejercicio2
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("PAISES DEL MUNDO\n");
                Console.WriteLine("1) Agregar país");
                Console.WriteLine("2) Mostrar países");
                Console.WriteLine("3) Buscar país");
                Console.WriteLine("4) Salir");
                Console.Write("Ingrese una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        try
                        {

                            Console.WriteLine("¿Cuantos paises agregara?");
                            int numpais = Convert.ToInt32(Console.ReadLine());
                            string[] pais = new string[numpais];
                            for (int j = 0; j < pais.Length; j++)
                            {
                                Console.WriteLine("\nIngrese el nombre del pais N°{0}: ", j+1);
                                pais[j] = Console.ReadLine();
                            }
                            string texto = string.Join(",", pais);
                            StreamWriter paises = new StreamWriter("paisesAUNI.txt", true);
                            paises.WriteLine(texto);
                            paises.Close();
                            Console.Clear();
                            Console.WriteLine("Paises agregado con exito presione\n Presione <Enter> para continuar");
                            Console.ReadKey();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ocurrio un error :v el archivo no se pudo crear");
                            Console.ReadKey();
                        }
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        string[] nombres = new string[999];
                        StreamReader verpais = new StreamReader("paisesAUNI.txt");
                        string text = verpais.ReadToEnd();
                        nombres = text.Split(',');
                        verpais.Close();
                        int i = 1;
                        Console.WriteLine("LISTA DE PAISES ALMACENADOS:\n");
                        foreach (string nombre in nombres)
                        {
                            Console.WriteLine("Pais {0}: {1}", i, nombre);
                            i++;
                        }
                        Console.WriteLine("Presione <ENTER> para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        StreamReader lect = new StreamReader("paisesAUNI.txt");
                        string paisEncontrar = "";
                        Console.WriteLine("Pais a encontrar:");
                        paisEncontrar = Console.ReadLine();


                        string line = lect.ReadLine();
                        Console.WriteLine(lect.ReadToEnd());
                        while (line != null)
                        {
                            while (line == paisEncontrar)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(paisEncontrar);
                            }
                            line = lect.ReadLine();
                        }

                        lect.Close();

                        break;
                }



            } while (opcion != 4);

        }
    }
}
