using System;

namespace Practica_1
{
    class ejercicio1
    {
        static void Main(string[] args)
        {
            string nom, esp;
            int edad;
            Console.WriteLine("Ingrese el nombre de su mascota: ");
            nom = Console.ReadLine();
            Console.WriteLine("Ingrese la especie de su mascota: ");
            esp = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de su mascota: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tu mascota se llama " + nom + ", el cual es de raza " + esp + " y tiene " + edad + " años de edad.");
            Console.ReadKey();
        }
    }
}
