using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    class ejercicio1
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
                            StreamWriter paises = new StreamWriter("paises.txt", true);
                            Console.WriteLine("Ingrese el nombre del pais a agregar: ");
                            string pais = Console.ReadLine();
                            paises.WriteLine(pais);
                            paises.Close();
                            Console.Clear();
                            Console.WriteLine("Pais agregado con exito presione\n Presione <Enter> para continuar");
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
                        Console.WriteLine("LISTA DE PAISES\n");
                        StreamReader pai = new StreamReader("paises.txt");
                        string linea;
                        do
                        {
                            linea = pai.ReadLine();
                            if (linea != null)
                            {
                                Console.WriteLine(linea);
                            }
                        } while (linea != null);
                        pai.Close();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        StreamReader lect = new StreamReader("paises.txt");
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
