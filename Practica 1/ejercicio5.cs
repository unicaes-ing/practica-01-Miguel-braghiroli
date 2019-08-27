using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class ejercicio5
    {
        static void Main(string[] args)
        {
            int selec;
            int[] mes;
            mes = new int[13];
            int[] prom;
            prom = new int[5];
            int[] total;
            total = new int[5];

            do
            {
                Console.Clear();

                Console.WriteLine("Seleccione:\n");
                Console.WriteLine("[1]Trimestre 1");
                Console.WriteLine("[2]Trimestre 2");
                Console.WriteLine("[3]Trimestre 3");
                Console.WriteLine("[4]Trimestre 4");
                Console.WriteLine("[5]Promedio de ventas");
                selec = Convert.ToInt32(Console.ReadLine());

                if (selec == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el total de ventas:");
                    mes[1] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el total de ventas:");
                    mes[2] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el total de ventas:");
                    mes[3] = Convert.ToInt32(Console.ReadLine());

                    total[1] = mes[1] + mes[2] + mes[3];
                    prom[1] = total[1] / 3;
                    Console.WriteLine("Promedio de ventas: {0}\n", prom[1]);
                    Console.WriteLine("Ingrese el '6' para regresar al menu");
                    selec = Convert.ToInt32(Console.ReadLine());
                }

                if (selec == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el total de ventas:");
                    mes[4] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el total de ventas:");
                    mes[5] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el total de ventas:");
                    mes[6] = Convert.ToInt32(Console.ReadLine());

                    total[2] = mes[4] + mes[5] + mes[6];
                    prom[2] = total[2] / 3;
                    Console.WriteLine("Promedio de ventas: {0}\n", prom[2]);
                    Console.WriteLine("Ingrese el '6' para regresar al menu");
                    selec = Convert.ToInt32(Console.ReadLine());
                }

                if (selec == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el total de ventas:");
                    mes[7] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el total de ventas:");
                    mes[8] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el total de ventas:");
                    mes[9] = Convert.ToInt32(Console.ReadLine());

                    total[3] = mes[7] + mes[8] + mes[9];
                    prom[3] = total[3] / 3;
                    Console.WriteLine("Promedio de ventas: {0}\n", prom[3]);
                    Console.WriteLine("Ingrese el '6' para regresar al menu");
                    selec = Convert.ToInt32(Console.ReadLine());
                }

                if (selec == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el total de ventas:");
                    mes[10] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el total de ventas:");
                    mes[11] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el total de ventas:");
                    mes[12] = Convert.ToInt32(Console.ReadLine());

                    total[4] = mes[10] + mes[11] + mes[12];
                    prom[4] = total[4] / 3;
                    Console.WriteLine("Promedio de ventas: {0}\n", prom[4]);
                    Console.WriteLine("Ingrese el '6' para regresar al menu");
                    selec = Convert.ToInt32(Console.ReadLine());
                }

                if (selec == 5)
                {
                    Console.Clear();
                    Console.WriteLine("RROMEDIO DE VENTAS REALIZADAS EN CADA TRIMESTRE");
                    Console.WriteLine("1° trimestre: {0}", prom[1]);
                    Console.WriteLine("2° trimestre: {0}", prom[2]);
                    Console.WriteLine("3° trimestre: {0}", prom[3]);
                    Console.WriteLine("4° trimestre: {0}", prom[4]);
                    Console.WriteLine("Ingrese el '6' para regresar al menus");
                    selec = Convert.ToInt32(Console.ReadLine());
                }
            } while (selec > 5);
        }
    }
}
