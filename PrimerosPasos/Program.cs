using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasos
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipos de datos
            int a,b,suma; //declarar una variable tipo entero 
            a = 10;
            b = 20;
            suma = a + b;
            Console.WriteLine("La suma de {0} + {1} = {2}", a, b, suma);
            Console.ReadKey();

            //tipo de dato; numero en coma flotante
            float sueldo, egreso, total;
            Console.Write("Ingresa el sueldo del trabajador: ");
            sueldo=float.Parse(Console.ReadLine());

            Console.Write("Ingresa los gastos del trabajador: ");
            egreso = float.Parse(Console.ReadLine());

            total = sueldo - egreso;

            Console.WriteLine("El liquido a recibir es: {0}", total);
            Console.ReadKey();
            //case sensitive

            //tipo de dato: flotante de doble precision
            double x1 = 200.5679;
            Console.WriteLine("Tipo de dato doble: {0}", x1);
            Console.ReadKey();

            //Tipo de dato: cadena de caracteres (string)
            String nombre;
            Console.Write("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ", bienvenido al curso de Programacion!!!");
            Console.ReadKey();

            //tipo de dato booleano (tipo logico: verdadero/falso) (true/false)
            bool sw;
            sw = (a+50) > b;
            Console.WriteLine("El valor del booleano sw: {0}", sw);
            Console.ReadKey();
        }
    }
}
