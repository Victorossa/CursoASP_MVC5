using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCast
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1100;
            int b = 0;
            //try = intente, lo que voy a intentar hacer  --- catch = atrape, que es lo que voy a hacer si eso falla -- finally = que tengo que hacer asi esto falle
            try
            {
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Upsss... {ex.Message}");
                Console.WriteLine($"Upsss... {ex.ToString()}");
            }
            finally
            {

            }

            try
            {
                var f = File.Open("./MiarchivoNoExistente", FileMode.Open);
            }
            catch (Exception ex)
            {
                //con Message es informacion basica
                //Console.WriteLine($"Upsss... {ex.Message}");
                //con ToString es informacion mas completa
                Console.WriteLine($"Upsss... {ex.ToString()}");
            }
            finally
            {
                //podemos cerrar conexiones o archivos, cualquier cosa que necesitemos en este punto
            }

            Console.ReadLine();
        }
    }
}
