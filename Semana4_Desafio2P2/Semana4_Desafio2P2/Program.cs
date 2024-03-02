using System;


namespace ProgramaJuego
{
    class Juego
    {
        public static void Main(string[] args)
        {

            int puntaje_personaje = 0;


            Console.WriteLine("Preguntas y respuestas");
            Console.WriteLine("Ingresa tu personaje:");
            string nombre = Console.ReadLine();

            Console.WriteLine("1. ¿Cual de estos juegos es el mas Vendido de la Historia?");
            Console.WriteLine("a. Minecraft");
            Console.WriteLine("b. GTA V");
            Console.WriteLine("c. Ninguno de los 2");
            string respuesta1 = Console.ReadLine();

            switch (respuesta1)
            {
                case "a":
                    Console.WriteLine("Respuesta Correcta");
                    puntaje_personaje = puntaje_personaje + 500;
                    break;
                case "b":
                    Console.WriteLine("Respuesta Incorrecta");
                    break;
                case "c":
                    Console.WriteLine("Respuesta Incorrecta");
                    break;
            }


            Console.WriteLine("2. ¿Cual de estos programas se utiliza para Edicion de Fotografia y/o imagenes?");
            Console.WriteLine("a. Photoshop");
            Console.WriteLine("b. Photomath");
            Console.WriteLine("c. Ningulo de los 2");
            string respuesta2 = Console.ReadLine();

            switch (respuesta2)
            {
                case "a":
                    Console.WriteLine("Respuesta Correcta");
                    puntaje_personaje = puntaje_personaje + 1500;
                    break;
                case "b":
                    Console.WriteLine("Respuesta Incorrecta");
                    break;
                case "c":
                    Console.WriteLine("Respuesta Incorrecta");
                    break;
            }

            Jugador(puntaje_personaje,nombre);


        }


        static void Jugador(double puntaje, string name)
        {
            double puntaje_alto = 1500;
            string jugador = "Kevin";

            if (puntaje >= puntaje_alto)
            {
                Console.WriteLine($"La nueva puntuacion mas alta es: {puntaje}");
                Console.WriteLine($"La puntuacion mas alta fue lograda por: {name}");
            }
            else
            {
                Console.WriteLine($"La puntuacion mas alta de: {puntaje_alto}, no ha sido superado");
                Console.WriteLine($"Aun estamos en manos de: {jugador}, con un puntaje de {puntaje_alto}");
            }
        }

    }

    
}

