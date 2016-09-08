using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            int num1, num2, multi;

            //Explicacion del Ejercicio
            Console.Write("\n\tMultiplicacion de Dos Numeros");

            //Ingresando el primer numero
            Console.Write("\nIngrese un numero: ");
            num1 = Int32.Parse(Console.ReadLine());

            //Ingresando el primer numero 
            Console.Write("\nIngrese el numero 2: ");
            num2 = Int32.Parse(Console.ReadLine());

            //Realizando la Multiplicacion
            multi = num1 * num2;

            //Mostrando Resultado
            Console.WriteLine("El Resultado es: " + multi);

            //Detener pantalla
            Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
            Console.ReadKey();
        }
    }
}
