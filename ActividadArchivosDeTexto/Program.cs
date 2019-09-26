using System;
using System.IO;

namespace ActividadFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console hasiera!");
            Console.Write(File.Exists("fichero1.txt"));

            
            using (StreamWriter outputFile = new StreamWriter("file.txt", true))
            {
                outputFile.WriteLine("Linea2");
            }

            String linea;
            using (StreamReader sr = new StreamReader("fichero1.txt")){
                  linea = sr.ReadLine();
                while((linea = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }

            string[] lineass = File.ReadAllLines("demo.csv");

            foreach(var lineas in lineass){
                var valores = lineas.Split(',');
                Console.WriteLine("El nombre es: " + valores[0] + "  Nombre usuario: " + valores[1] + "  Direccion de correo: " + valores[2]);
            }

            


            Console.WriteLine("Fin de aplicacion!");
        }
    }
}