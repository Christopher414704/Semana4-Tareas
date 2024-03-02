using System;

namespace Programa
{

    class Desafio3
    {
        public static void Main(string[]args)
        {
            int resultado = Sumatoria();

            Console.WriteLine($"La sumatoria es de: {resultado}");   

        }

        public static int Sumatoria()
        {

            Console.WriteLine("Ingresa el primer Valor");
            string valor1 = Console.ReadLine();
            Console.WriteLine("Ingresa el segundo Valor");
            string valor2 = Console.ReadLine();

            int val1 = 0 ;
            int val2 = 0 ;

            try
            {
                val1 = Convert.ToInt32(valor1);
                val2 = Convert.ToInt32(valor2);


            }
            catch(FormatException)
            {
                Console.WriteLine("El formato que se utiliza no es el correcto");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error en los datos, Verifica bien " + ex.Message);
            }

            return val1 + val2;
        }


    }


}