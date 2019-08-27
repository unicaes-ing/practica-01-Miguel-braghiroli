using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class ejercicio4
    {
        static void Main(string[] args)
        {
            double num;
            Console.Write("Ingrese un numero entero positivo: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La raiz cuadrada de el numero ingresado es: {0}\n", Math.Sqrt(num));
            Console.ReadKey();
        }
    }
}
