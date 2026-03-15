namespace TipoListasParte2;

class Program
{
    static void Main(string[] args)
    {
        List<string> strings = new List<string>();

        strings.Add("Laurinane");
        strings.Add("Hello World");
        Console.WriteLine(strings[0]);
        Console.WriteLine(strings[1]);
        Console.WriteLine();

        List<decimal> dinheiro = new List<decimal>();
        dinheiro.Add(2.50m);
        Console.WriteLine(dinheiro[0]);
        Console.WriteLine();

        List<bool> verdadeiroFalso = new List<bool>();
        verdadeiroFalso.Add(true);       
        Console.WriteLine(verdadeiroFalso[0]);
        Console.WriteLine();

        List<object> objetos = new List<object>();
        objetos.Add(2026);
        objetos.Add("Hello World");
        objetos.Add('A');
        objetos.Add(true);

        Console.WriteLine(objetos[0]);
        Console.WriteLine(objetos[1]);
        Console.WriteLine(objetos[2]);
        Console.WriteLine(objetos[3]);
        Console.WriteLine();

        string resultado = string.Join(" * ", objetos);
        Console.WriteLine(resultado);

        Console.ReadKey();
    }
}