// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de productos: ");
        int N = int.Parse(Console.ReadLine());

        double subtotal = 0;

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"\nProducto {i + 1}");

            Console.Write("Ingrese el precio: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());

            subtotal += precio * cantidad;
        }

        double igv = subtotal * 0.18;
        double total = subtotal + igv;

        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine($"Subtotal: S/ {subtotal:F2}");
        Console.WriteLine($"IGV (18%): S/ {igv:F2}");
        Console.WriteLine($"Total a pagar: S/ {total:F2}");
    }
}

