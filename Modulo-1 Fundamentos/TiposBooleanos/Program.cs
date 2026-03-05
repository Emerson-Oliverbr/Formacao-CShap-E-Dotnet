namespace TiposBooleanos;

class Program
{
    static void Main(string[] args)
    {
        string? usuarioCorreto = "admin";
        string? senhaCorreta = "1234";

        Console.Write("Usuário: ");
        string? usuarioInput = Console.ReadLine();

        Console.Write("Senha: ");
        string? senhaInput = Console.ReadLine();
        
        bool credenciaisValidas = (usuarioInput == usuarioCorreto) && (senhaInput == senhaCorreta);
        bool contaBloqueada = false;

        if (credenciaisValidas && !contaBloqueada)
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Falha no login. Verifique os dados ou o status da conta.");
        }
    }
}