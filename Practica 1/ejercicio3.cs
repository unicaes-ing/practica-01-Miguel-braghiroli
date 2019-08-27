using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class ejercicio3
    {
        static void Main(string[] args)
        {
            string numA = "Numero Agregado: ";
            decimal N1, N2, RS, RR, RM, RD;
            Console.Write("Ingrese el primer numero: ");
            N1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("{0} {1}\n", numA, N1);
            Console.Write("Ingrese el segundo numero: ");
            N2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("{0} {1}", numA, N2);
            Console.WriteLine("Loading...");
            Console.WriteLine("Presiona 'Enter' para continuar");
            Console.ReadKey();

            RS = N1 + N2;
            RR = N1 - N2;
            RM = N1 * N2;
            RD = N1 / N2;

            Console.Clear();
            Console.WriteLine("La respuesta de la sumatoria anterior es: {0}\n", Math.Round(RS, 1));
            Console.WriteLine("La respuesta de la resta anterior es: {0}\n", Math.Round(RR, 1));
            Console.WriteLine("La respuesta de la multiplicacion anterior es: {0}\n", Math.Round(RM, 1));
            Console.WriteLine("La respuesta de la division anterior es: {0}\n", Math.Round(RD, 1));

            Console.ReadKey();
        }
    }
}
