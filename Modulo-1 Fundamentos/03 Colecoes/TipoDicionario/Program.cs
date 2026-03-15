namespace TipoDicionario;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> dicionario = new Dictionary<int, string>();
        dicionario.Add(1, "Joao");
        dicionario.Add(2, "Maria");
        dicionario.Add(3, "Fada");

        string value = dicionario[1];
        string value2 = dicionario[3];

        Console.WriteLine(value);
        Console.WriteLine(value2);
        Console.WriteLine();

        bool existe = dicionario.ContainsKey(1);
        bool existe2 = dicionario.ContainsKey(4);

        Console.WriteLine(existe);
        Console.WriteLine(existe2);

        Console.Out.Flush();
        Console.ReadKey();
    }
}