using System;
using System.Collections.Generic;

class Program
{
    public static List<int> EncontrarNumerosEscondidos(int A, int B, int C, int D, List<int> E)
    {
        List<int> numerosEncontrados = new List<int>();

        for (int i = A; i <= B; i++)
        {
            int somaDigitos = SomaDigitos(i);
            bool divisivel = DivisivelporC(i, C);
            bool contemDigitoInvalido = ContemDigitoInvalido(i, E);


            if (divisivel && somaDigitos >= D && !contemDigitoInvalido)
            {
                numerosEncontrados.Add(i);
            }
        }

        return numerosEncontrados;
    }

    static bool DivisivelporC(int numero, int C) => numero % C == 0;

    static int SomaDigitos(int numero)
    {
        int soma = 0;
        while (numero > 0)
        {
            soma += numero % 10;
            numero /= 10;
        }
        return soma;
    }

    static bool ContemDigitoInvalido(int numero, List<int> E)
    {
        foreach (var digito in E)
        {
            if (numero.ToString().Contains(digito.ToString()))
            {
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        int A = 2, B = 30, C = 2, D = 4;
        List<int> E = new List<int> { 5, 6 };

        var resultado = EncontrarNumerosEscondidos(A, B, C, D, E);

        Console.WriteLine("Os números encontrados são:\n");
        Console.WriteLine(string.Join(" | ", resultado));
    }
}
