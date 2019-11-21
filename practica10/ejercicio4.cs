using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    class ejercicio4
    {
        static void Main(string[] args)
        {
            StreamReader archivo = new StreamReader("ejercicio3.txt");
            string contra;
            contra = archivo.ReadLine();
            contra = contra.Remove(1, 1);
            contra = contra.Remove(2, 1);
            contra = contra.Replace("%", "a");
            contra = contra.Replace("/", "e");
            Console.WriteLine(contra);
            archivo.Close();
            Console.ReadKey();
        }
    }
}
