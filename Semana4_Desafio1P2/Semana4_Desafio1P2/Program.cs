using System;
using System.Net;

namespace logeo
{
    class logeo
    {
        public static void Main(string[]args)
        {
            string user = "Christopherb577";
            string password = "Christian1234";

            Console.WriteLine("Introduce un Usuario:");
            string usuario = Console.ReadLine();
            Console.WriteLine("Introduce una Contraseña");
            string contrasena = Console.ReadLine();

            if (usuario == user && contrasena == password)
            {
                Console.WriteLine("Bienvenido a nuestro Sistema");
            }
            else
            {
                Console.WriteLine("Error: Verifica si los datos estan correctamente");
            }
        }
    }
}
