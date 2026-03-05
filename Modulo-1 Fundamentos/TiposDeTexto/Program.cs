namespace TiposDeTexto;

class Program
{
    static void Main(string[] args)
    {
        //char
        //string
        Console.Clear();

        char letra = 'A';
        char numero = '1';
        char caracter = '@';

        string texto = "Hello World";
        char primeiraLetraDoTexto = texto[0];
        Console.WriteLine(texto);
        Console.WriteLine(primeiraLetraDoTexto);


        string meuNomeCompleto = "           Emerson Matos Oliveira";
        Console.WriteLine(meuNomeCompleto);
        string meuNomeCompletoSemEspaco = meuNomeCompleto.Trim();
        Console.WriteLine(meuNomeCompletoSemEspaco);

        //bool comecaComALetraE = meuNomeCompletoSemEspaco.StartsWith("E");
        bool comecaComALetraE = meuNomeCompletoSemEspaco.StartsWith("e");
        //bool comecaComALetraE = meuNomeCompletoSemEspaco.StartsWith("M");
        Console.WriteLine(comecaComALetraE);

        //bool terminaComALetraA = meuNomeCompletoSemEspaco.EndsWith("A");
        bool terminaComALetraA = meuNomeCompletoSemEspaco.EndsWith("a");
        //bool terminaComALetraA = meuNomeCompletoSemEspaco.EndsWith("X");
        Console.WriteLine(terminaComALetraA);

        bool existe = texto.Contains("Hello");
        bool naoExiste = texto.Contains("hello");

        Console.WriteLine(existe);
        Console.WriteLine(naoExiste);

        Console.ReadKey();
    }
}

