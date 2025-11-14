// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        string nombre;

        while (true)
        {
            Console.Write("Ingrese el nombre del estudiante (o escriba FIN para terminar): ");
            nombre = Console.ReadLine();

            if (nombre.ToUpper() == "FIN")
                break;

            Console.Write("Ingrese la nota 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 3: ");
            double n3 = double.Parse(Console.ReadLine());

            double promedio = (n1 + n2 + n3) / 3;

            string estado;

            if (promedio >= 0 && promedio <= 10)
                estado = "Desaprobado";
            else if (promedio >= 11 && promedio <= 14)
                estado = "Recuperación";
            else if (promedio >= 15 && promedio <= 20)
                estado = "Aprobado";
            else
                estado = "Promedio no válido";

            Console.WriteLine($"\nHola {nombre}, tu estado es: {estado}\n");
        }

        Console.WriteLine("Programa finalizado.");
    }
}

