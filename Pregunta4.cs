// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // ------------------------------
    // Métodos para calcular área y perímetro
    // ------------------------------
    static (double, double) Cuadrado(double lado)
    {
        double area = lado * lado;
        double perimetro = 4 * lado;
        return (area, perimetro);
    }

    static (double, double) Rectangulo(double baseRect, double altura)
    {
        double area = baseRect * altura;
        double perimetro = 2 * (baseRect + altura);
        return (area, perimetro);
    }

    static (double, double) Circulo(double radio)
    {
        double area = Math.PI * Math.Pow(radio, 2);
        double perimetro = 2 * Math.PI * radio;
        return (area, perimetro);
    }

    // ------------------------------
    // Método para mostrar menú
    // ------------------------------
    static string MostrarMenu()
    {
        Console.WriteLine("\n--- MENÚ DE OPCIONES ---");
        Console.WriteLine("1. Calcular área y perímetro de un Cuadrado");
        Console.WriteLine("2. Calcular área y perímetro de un Rectángulo");
        Console.WriteLine("3. Calcular área y perímetro de un Círculo");
        Console.WriteLine("4. Salir");
        Console.Write("Seleccione una opción: ");
        return Console.ReadLine();
    }

    // ------------------------------
    // Programa principal
    // ------------------------------
    static void Main()
    {
        while (true)
        {
            string opcion = MostrarMenu();

            if (opcion == "1")
            {
                Console.Write("Ingrese el lado del cuadrado: ");
                double lado = double.Parse(Console.ReadLine());
                var resultado = Cuadrado(lado);
                Console.WriteLine($"Área: {resultado.Item1:F2}, Perímetro: {resultado.Item2:F2}");
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese la base del rectángulo: ");
                double baseRect = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura del rectángulo: ");
                double altura = double.Parse(Console.ReadLine());
                var resultado = Rectangulo(baseRect, altura);
                Console.WriteLine($"Área: {resultado.Item1:F2}, Perímetro: {resultado.Item2:F2}");
            }
            else if (opcion == "3")
            {
                Console.Write("Ingrese el radio del círculo: ");
                double radio = double.Parse(Console.ReadLine());
                var resultado = Circulo(radio);
                Console.WriteLine($"Área: {resultado.Item1:F2}, Perímetro: {resultado.Item2:F2}");
            }
            else if (opcion == "4")
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente nuevamente.");
            }
        }
    }
}

