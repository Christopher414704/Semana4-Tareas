using System;
using System.Diagnostics.CodeAnalysis;


namespace Sueldo
{

    public class Sueldos
    {

        public static void Main(string[]args)
        {
            double[] ingresos = new double[3]; 
            Console.WriteLine("Ingresa tu Nombre");
            string nombre = Console.ReadLine();

            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine($"Ingresa {nombre} el sueldo del mes {x+1}");
                ingresos[x] = Convert.ToDouble(Console.ReadLine());                
                
            }

            double sumaIngresos = SumatoriaIngresos(ingresos);
            double promedioIngresos = PromedioIngresos(ingresos);
            

            Console.WriteLine($"Hola {nombre} tu sueldo sumado de los ultimos meses es de: {sumaIngresos}");
            Console.WriteLine($"Y tu promedio de sueldo es de: {promedioIngresos}");
            
        }

        public static double SumatoriaIngresos(double [] ingresos)
        {
            double sumatoria = 0;
            foreach (double ingreso in ingresos)
            {
                sumatoria += ingreso;
            }

            return sumatoria;

        }

        public static double PromedioIngresos(double[] ingresos)
        {
            double suma = SumatoriaIngresos(ingresos);
            return suma / ingresos.Length;
        }

    }


}