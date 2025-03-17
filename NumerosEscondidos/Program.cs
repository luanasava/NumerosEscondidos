using System;
using System.Collections.Generic;

class Program
{
    public static List<int> EncontrarNumerosEscondidos(int A, int B, int C, int D, List<int> E)
    {
        List<int> numerosEncontrados = new List<int>();


        if (A <= 0 || B <= 0)
            throw new ArgumentException("A e B devem ser números positivos.");
        if (A > B)
            throw new ArgumentException("A deve ser menor ou igual a B.");
        if (C <= 0)
            throw new ArgumentException("C deve ser um número positivo.");
        if (D < 1)
            throw new ArgumentException("D deve ser um número positivo maior que 0: ");

        if (E.Any(digito => digito < 0 || digito > 9))
            throw new ArgumentException("Todos os elementos da lista E devem estar entre 0 e 9.");



        for (int i = A; i <= B; i++)
        {
            if (i % C != 0)
                continue;

            int somaDigitos = SomaDigitos(i);
            bool contemDigitoInvalido = ContemDigitoInvalido(i, E);

            if (somaDigitos >= D && !contemDigitoInvalido)
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
        while (numero > 0)
        {
            int digito = numero % 10;
            if (E.Contains(digito))
                return true;
            numero /= 10;
        }
        return false;
    }

    static void Main(string[] args)
    {


        int A = 10, B = 50, C = 5, D = 5;
        List<int> E = new List<int> { 3, 7 };
        var resultado = EncontrarNumerosEscondidos(A, B, C, D, E);
        Console.WriteLine("Teste: " + string.Join(" | ", resultado));



        int A1 = 30, B1 = 100, C1 = 10, D1 = 7;
        List<int> E1 = new List<int> { 5, 9 };
        var resultado1 = EncontrarNumerosEscondidos(A1, B1, C1, D1, E1);
        Console.WriteLine("Teste 1: " + string.Join(" | ", resultado1));


        int A2 = 10, B2 = 20, C2 = 2, D2 = 5;
        List<int> E2 = new List<int>();
        var resultado2 = EncontrarNumerosEscondidos(A2, B2, C2, D2, E2);
        Console.WriteLine("Teste 2: " + string.Join(" | ", resultado2));


        int A3 = 10, B3 = 15, C3 = 5, D3 = 3;
        List<int> E3 = new List<int> { 2 };
        var resultado3 = EncontrarNumerosEscondidos(A3, B3, C3, D3, E3);
        Console.WriteLine("Teste 3: " + string.Join(" | ", resultado3));


        int A4 = 1, B4 = 20, C4 = 1, D4 = 5;
        List<int> E4 = new List<int> { 9 };
        var resultado4 = EncontrarNumerosEscondidos(A4, B4, C4, D4, E4);
        Console.WriteLine("Teste 4: " + string.Join(" | ", resultado4));


        int A5 = 100, B5 = 200, C5 = 10, D5 = 1;
        List<int> E5 = new List<int> { 0, 1 };
        var resultado5 = EncontrarNumerosEscondidos(A5, B5, C5, D5, E5);
        Console.WriteLine("Teste 5: " + string.Join(" | ", resultado5));


        int A6 = 40, B6 = 40, C6 = 10, D6 = 5;
        List<int> E6 = new List<int> { 3 };
        var resultado6 = EncontrarNumerosEscondidos(A6, B6, C6, D6, E6);
        Console.WriteLine("Teste 6: " + string.Join(" | ", resultado6));


        int A7 = 20, B7 = 30, C7 = 25, D7 = 1;
        List<int> E7 = new List<int> { 9 };
        var resultado7 = EncontrarNumerosEscondidos(A7, B7, C7, D7, E7);
        Console.WriteLine("Teste 7: " + string.Join(" | ", resultado7));

        try
        {
            int A8 = 10, B8 = 20, C8 = 2, D8 = 5;
            List<int> E8 = new List<int> { 10 }; 
            var resultado8 = EncontrarNumerosEscondidos(A8, B8, C8, D8, E8);
            Console.WriteLine("Teste 8: " + string.Join(" | ", resultado8));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Teste 8: " + ex.Message);
        }
    }
}