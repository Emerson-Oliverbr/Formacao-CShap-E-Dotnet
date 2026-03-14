namespace TipoEnum;

class Program
{
    enum NivelDeDificuldade
    {
        Baixo = 0,
        Medio = 1,
        Alto = 2
    }

    static void Main(string[] args)
    {
        NivelDeDificuldade nivel = NivelDeDificuldade.Alto;

        int nivelInteiro = (int) nivel;

        Console.WriteLine(nivel);
        Console.WriteLine(nivelInteiro);
    }
}