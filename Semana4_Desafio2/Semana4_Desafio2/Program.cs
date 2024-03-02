using System;

namespace calculadora
{
    public class Funciones()
    {
        public int Suma(int num1 , int num2)
        {
            return num1 + num2;
        }
        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }

    public class Programa()
    {
        static void Main(string[] args)
        {
            Funciones oFunciones = new Funciones();

         
            Console.WriteLine("Ingrese el primer numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Ingresa el segundo numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int resultado1 = oFunciones.Suma(numero1, numero2);
            Console.WriteLine($"El resultado de la suma es: {resultado1}");

            int resultado2 = oFunciones.Resta(numero1, numero2);
            Console.WriteLine($"El resultado de la resta es: {resultado2}");

            int resultado3 = oFunciones.Multiplicacion(numero1, numero2);
            Console.WriteLine($"El resultado de la multiplicacion es: {resultado3}");

            int resultado4 = oFunciones.Division(numero1, numero2);
            Console.WriteLine($"El resultado de la division es: {resultado4}");


        }
    }

}