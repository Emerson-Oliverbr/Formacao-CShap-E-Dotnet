namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[] inteiros = new int[10];

        inteiros[0] = 0;
        inteiros[1] = 1;
        inteiros[2] = 2;
        inteiros[3] = 3;
        inteiros[4] = 4;
        inteiros[5] = 5;
        inteiros[6] = 6;
        inteiros[7] = 7;
        inteiros[8] = 8;
        inteiros[9] = 9;

        Console.WriteLine("Tamanho do meu array: " + inteiros.Length);
        Console.WriteLine();

        Console.WriteLine("Valores do meu Array");
        Console.WriteLine($"{inteiros[0]}");
        Console.WriteLine($"{inteiros[1]}");
        Console.WriteLine($"{inteiros[2]}");
        Console.WriteLine($"{inteiros[3]}");
        Console.WriteLine($"{inteiros[4]}");
        Console.WriteLine($"{inteiros[5]}");
        Console.WriteLine($"{inteiros[6]}");
        Console.WriteLine($"{inteiros[7]}");
        Console.WriteLine($"{inteiros[8]}");
        Console.WriteLine($"{inteiros[9]}");
        Console.WriteLine();

        for(int i=0; i<inteiros.Length; i+=1)
        {
            Console.WriteLine($"Indice: {i} = {inteiros[i]}");
        }

        int[,] numeros = new int[10, 10];
        numeros[0, 1] = 1;
        numeros[0, 3] = 2;

        Console.WriteLine();
        Console.WriteLine(numeros[0,0]);
        Console.WriteLine(numeros[0,1]);
        Console.WriteLine(numeros[0,2]);
        Console.WriteLine(numeros[0,3]);

        Console.ReadKey();
    }
}