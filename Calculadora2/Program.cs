using System;

// Clase base que define el método abstracto para calcular el área
abstract class Figura
{
    public abstract double CalcularArea(); // Método que cada figura implementará
}

// Clase Rectángulo
class Rectangulo : Figura
{
    private double Base;
    private double Altura;

    public Rectangulo(double baseRect, double altura)
    {
        Base = baseRect;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Base * Altura; // Fórmula del área de un rectángulo
    }
}

// Clase Círculo
class Circulo : Figura
{
    private double Radio;

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio; // Fórmula del área de un círculo
    }
}

// Clase Triángulo
class Triangulo : Figura
{
    private double Base;
    private double Altura;

    public Triangulo(double baseTri, double altura)
    {
        Base = baseTri;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2; // Fórmula del área de un triángulo
    }
}
//Me gustan las salchipapas
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Menú principal
            Console.WriteLine("\nCalculadora de áreas");
            Console.WriteLine("1. Rectángulo");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": // Opción para calcular el área de un rectángulo
                    Console.Write("Ingrese la base del rectángulo: ");
                    double baseRect = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del rectángulo: ");
                    double alturaRect = Convert.ToDouble(Console.ReadLine());
                    Rectangulo rectangulo = new Rectangulo(baseRect, alturaRect);
                    Console.WriteLine($"El área del rectángulo es: {rectangulo.CalcularArea()}");
                    break;

                case "2": // Opción para calcular el área de un círculo
                    Console.Write("Ingrese el radio del círculo: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    Circulo circulo = new Circulo(radio);
                    Console.WriteLine($"El área del círculo es: {circulo.CalcularArea()}");
                    break;

                case "3": // Opción para calcular el área de un triángulo
                    Console.Write("Ingrese la base del triángulo: ");
                    double baseTri = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    double alturaTri = Convert.ToDouble(Console.ReadLine());
                    Triangulo triangulo = new Triangulo(baseTri, alturaTri);
                    Console.WriteLine($"El área del triángulo es: {triangulo.CalcularArea()}");
                    break;

                case "4": // Opción para salir del programa
                    Console.WriteLine("Saliendo de la calculadora. ¡Hasta luego!");
                    return;

                default: // Manejo de opciones inválidas
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                    break;
            }
        }
    }
}

