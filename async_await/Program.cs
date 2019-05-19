using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaro una variable tipo 
            var file1 = new FileStream("./Miarchivo1.bin", FileMode.OpenOrCreate);
            var file2 = new FileStream("./Miarchivo2.bin", FileMode.OpenOrCreate);
            Console.WriteLine("Antes de Inicio de  Procesos");
            ProcesarArchivoAsync(file1);
            ProcesarArchivo2Async(file2);
            Console.WriteLine("Despues de Procesos");
            Console.ReadLine();

        }
        /// <summary>
        /// Ejecuta la accion 100.000 veces
        /// </summary>
        /// <param name="file"></param>
        private static async void ProcesarArchivoAsync(FileStream file)
        {
            var msg = "Hola Mundo";
            var bytes = Encoding.UTF8.GetBytes(msg);
            Console.WriteLine("Procesando P 1");
            for (int i = 0; i < 100000; i++)
            {
                await file.WriteAsync(bytes, 0, bytes.Length);
            }
            file.Close();
            Console.WriteLine("Fin P 1");
        }
        /// <summary>
        /// ejecuta la accion 10000 veces, este termina primero
        /// </summary>
        /// <param name="file"></param>
        private static async void ProcesarArchivo2Async(FileStream file)
        {
            var msg = "Hola Mundo";
            var bytes = Encoding.UTF8.GetBytes(msg);
            Console.WriteLine("Procesando P 2");
            for (int i = 0; i < 10000; i++)
            {
                await file.WriteAsync(bytes, 0, bytes.Length);
            }
            file.Close();
            Console.WriteLine("Fin P 2");
        }
    }
}
