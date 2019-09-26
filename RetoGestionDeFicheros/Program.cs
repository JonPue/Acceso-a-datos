using System;
using System.IO;

//Aplicacion para que al introducir un numero te salga la tabla de multiplicar. Ejemplo poner el 5 y que te salga del1 al 12 multiplicando el 5.
namespace ActividadArchivoResumen
{
    class Program
    {
         static void Main(string[] args)
        {

        //string[] lineas = File.ReadAllLines("demo.csv");
        /* 
        int a = 1;
        int b = 0;
        int c = 0;

        Console.Write("Escribe un numero de la tabla: ");
        b = int.Parse(Console.ReadLine());

        using (StreamWriter Escribir = new StreamWriter("Tabla.txt"))
            {
            while(a <= 12){
                c = a * b;

                Escribir.WriteLine(a + " X " + b + " = " + c);

                a = a + 1;

            }

            }

            Console.ReadKey();*/

            int a = 1;
            int b = 0;
            int c = 0;

            string[] lines = {};
            Console.Write("Escribe un numero: ");
            b = int.Parse(Console.Readline());

            while(a <= 12){
                c = a * b;

                string line = (a + " X " + b + " = " + c);

                a = a + 1;

                lines[a-1] line;

            }

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Tabla.txt"))){
                foreach (string line in lines)
                    outputFile.WriteLine(line); 
            }





        
        }
    }
}
