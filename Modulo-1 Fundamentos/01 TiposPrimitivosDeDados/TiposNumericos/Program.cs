using System.Globalization;

namespace TiposNumericos;

class Program
{
    static void Main(string[] args)
    {
        int numero = 7;
        long numero2 = 7;
        uint numero3 = 7;
        sbyte numero4 = 127;
        sbyte numero5 = -128;
        Console.WriteLine("Tipos Inteiros");
        Console.WriteLine($"{numero}");
        Console.WriteLine($"{numero2}");
        Console.WriteLine($"{numero3}");
        Console.WriteLine($"{numero4}");
        Console.WriteLine($"{numero5}");

        Console.WriteLine("---- Tipos Real ----");

        double pi = 3.14159;
        float altura = 1.60f;
        decimal salario = 3448.00m;

        Console.WriteLine($"{pi}");
        Console.WriteLine($"{pi.ToString("F2")}");
        Console.WriteLine($"{altura}");
        Console.WriteLine($"{salario}");

        Console.WriteLine("---- Com ponto como separador ----");

        Console.WriteLine($"{pi.ToString("F5", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"{pi.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"{altura.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"{salario.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine("-------------");
        Console.ReadKey();
    }
}