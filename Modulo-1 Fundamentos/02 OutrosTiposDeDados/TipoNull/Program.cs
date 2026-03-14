namespace TipoNull;

class Program
{
    static void Main(string[] args)
    {
        int? idade = null;
        string? nome = null;

        Console.WriteLine("Idade" + idade);
        Console.WriteLine("Nome" + nome);

        bool informouIdade = idade.HasValue;
        bool informouNome = nome == null;

        Console.WriteLine($"Informou o nome: {informouNome}");
        Console.WriteLine($"Informou a idade: {informouIdade}");
    }
}