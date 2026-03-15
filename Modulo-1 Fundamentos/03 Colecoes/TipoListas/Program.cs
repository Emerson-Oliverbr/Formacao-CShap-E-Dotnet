namespace TipoListas;

class Program
{
    static void Main(string[] args)
    {
        List<int> inteiros = new List<int>();

        Console.WriteLine(inteiros.Count);
        Console.WriteLine();
        inteiros.Add(1);
        inteiros.Add(2);
        inteiros.Add(3);
        inteiros.Add(4);

        Console.WriteLine(inteiros.Count);
        Console.WriteLine();
        Console.WriteLine(inteiros[0]);
        Console.WriteLine(inteiros[1]);
        Console.WriteLine();
        inteiros.Remove(1);
        Console.WriteLine(inteiros.Count);
        Console.WriteLine();

        int primeiroElemento = inteiros.First();
        Console.WriteLine(primeiroElemento);
        Console.WriteLine();

        int ultimoElemento = inteiros.Last();
        Console.WriteLine(ultimoElemento);

        Console.WriteLine();
        int elementoAleatorio = inteiros.ElementAt(1);
        Console.WriteLine(elementoAleatorio);
        Console.WriteLine();
        inteiros.Clear();
        Console.WriteLine(inteiros.Count); 



        Console.ReadKey();
    }
}