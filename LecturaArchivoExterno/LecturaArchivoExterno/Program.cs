using System;

namespace LecturaArchivoExterno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;
                int contador = 0;
                string patch = @"C:\Users\Home\Desktop\tirar.txt";
                archivo = new System.IO.StreamReader(patch);
                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error con la lectura del archivo");
            }
            finally
            {if (archivo != null) archivo.Close();
                Console.WriteLine("Cerrando la conexion de la lectura");

            }
        }
    }
}
