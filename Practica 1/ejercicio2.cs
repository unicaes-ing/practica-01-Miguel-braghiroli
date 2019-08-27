using System;

namespace Practica_1
{
    class ejercicio2
    {
        static void Main(string[] args)
        {
            string nom, cargo, cor, contra;
            int edad, sueldo;
            Console.WriteLine("Ingrese el nombre del empleado: ");
            nom = Console.ReadLine();
            Console.WriteLine("Ingrese el cargo del empleado en la empresa: ");
            cargo = Console.ReadLine();
            Console.WriteLine("Ingrese el correo electronico: ");
            cor = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del empleado: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de contrato del empleado: ");
            contra = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado: ");
            sueldo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El nombre del empleado es " + nom + " , su edad es de " + edad + " años de edad, " +
                "tomara el cargo de " + cargo + " , su correo electronico es " + cor + 
                " , la fecha de contratacion del empleado es el " + contra + " y el sueldo que este ganara sera " +
                "de " + sueldo + ".");
            Console.ReadKey();
        }
    }
}
