using System;
using System.IO;

namespace ActividadFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console hasiera!");

            String linea;
            using (StreamReader sr = new StreamReader("fichero1.txt"))
            {
                //linea = sr.ReadLine();
                while((linea = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }


            Console.WriteLine("Fin de aplicacion!");
        }
    }
}
