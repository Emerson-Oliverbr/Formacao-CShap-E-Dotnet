using System.Globalization;

namespace DatasHoras;

class Program
{
    static void Main(string[] args)
    {
        DateOnly dia = new DateOnly(2026,03,05);
        Console.WriteLine(dia);

        string diaTexto = dia.ToLongDateString();
        Console.WriteLine(diaTexto);

        string diaTexto2 = dia.ToString(new CultureInfo("pt-BR"));
        Console.WriteLine(diaTexto2);
        Console.WriteLine("-------------");

        string diaTexto3 = dia.ToString("R", new CultureInfo("pt-BR"));
        Console.WriteLine(diaTexto3);

        Console.WriteLine("-------------");
        string diaTexto4 = dia.ToString("d MMM yyy", new CultureInfo("pt-BR"));
        Console.WriteLine(diaTexto4);

        Console.WriteLine("-------------");
        string diaTexto5 = dia.ToString("d MMMM yyy", new CultureInfo("pt-BR"));
        Console.WriteLine(diaTexto5);

        Console.WriteLine("-------------");
        string diaTexto6 = dia.ToString("d/MMMM/yyy", new CultureInfo("pt-BR"));
        Console.WriteLine(diaTexto6);

        Console.WriteLine("-------------");
        string diaTexto7 = dia.ToString("dd/MMMM/yyy", new CultureInfo("pt-BR"));
        Console.WriteLine(diaTexto7);


        Console.WriteLine("-------------");

        DateTime dia1 = new DateTime(2023, 12, 1);
        Console.WriteLine( dia1);
        Console.WriteLine("--------------------");

        DateTime dia2 = new DateTime(2023, 12, 1, 22,18,59);
        Console.WriteLine(dia2);
        Console.WriteLine("--------------------");

        DateTime hoje = DateTime.Now;
        Console.WriteLine(hoje);

        DateTime hoje2 = DateTime.Today;
        Console.WriteLine(hoje2);

        DateTime hoje3 = DateTime.UtcNow;
        Console.WriteLine(hoje3);

        Console.ReadKey();
    }
}