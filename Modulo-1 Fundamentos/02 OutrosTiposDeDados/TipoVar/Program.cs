namespace TipoVar;

class Program
{
    static void Main(string[] args)
    {
        string meuNomeCompleto = "Emerson M Oliveira" ?? "0";
        var meuNome = "Emerson" ?? "0";

        int ano = 2026;
        var ano2 = 2025;

        Console.WriteLine($"{ano} {ano2}");
        Console.WriteLine($"{meuNome} - {meuNomeCompleto}");
    }
}