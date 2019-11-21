using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    class ejercicio3
    {
        static void Main(string[] args)
        {
            string contra;
            StreamWriter archivo = new StreamWriter("ejercicio3.txt", false);
            do
            {
                Console.WriteLine("Ingrese una contraseña entre 7 y 20 caracteres");
                contra = Console.ReadLine();
            } while (contra.Length < 7 || contra.Length > 20);
            contra = contra.Insert(1, "@");
            contra = contra.Insert(3, "$");
            contra = contra.Replace("a", "*");
            contra = contra.Replace("e", "&");
            archivo.WriteLine(contra);
            archivo.Close();
            Console.WriteLine("Contraseña guardada");
            Console.ReadKey();
        }
    }
}
