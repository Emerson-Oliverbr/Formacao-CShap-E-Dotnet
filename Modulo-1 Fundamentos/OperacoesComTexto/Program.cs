using System.Text;

namespace OperacoesComTexto;

class Program
{
    static void Main(string[] args)
    {
        string frase1 = "Hello";
        string frase2 = "World";    
        Console.WriteLine($"{frase1} {frase2}");

        string frase3 = frase1 + " " + frase2;
        Console.WriteLine(frase3);

        string caminho = "C:\teste";
        Console.WriteLine(caminho);

        string caminho2 = "C:\\teste";
        Console.WriteLine(caminho2);

        string caminho3 = "C:\\teste\\visualstudio\\c#";
        Console.WriteLine(caminho3);

        string caminho4 = @"C:\teste";
        Console.WriteLine(caminho4);

        string outraFrase = "C# e uma otima linguagem de \nprogramaç♦ão";
        Console.WriteLine(outraFrase);

        StringBuilder stringbuilder = new StringBuilder();
        stringbuilder.Append(frase2);
        stringbuilder.Append(frase3);

        string resultado = stringbuilder.ToString();
        Console.WriteLine(resultado);
    }
}