using System;

/*
Problema 12: Maior número triangular divisível
A sequência de números de triângulos é gerada pela adição de números naturais. Portanto, o número do 7º triângulo é 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. Os primeiros dez termos seriam:

1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
Abaixo está a lista dos 7 primeiros números do triângulo:

1: 1
3: 1, 3
6: 1, 2, 3, 6
10: 1, 2, 5, 10
15: 1, 3, 5, 15
21: 1, 3, 7, 21
28: 1, 2, 4, 7, 14, 28
Podemos ver que 28 é o primeiro triângulo a ter mais de cinco divisores.

Qual é o valor do primeiro triângulo a ter mais de n divisores?
*/
Console.WriteLine(MaiorNumeroTriangularDivisivel(5)); //Deve retornar 28
Console.WriteLine(MaiorNumeroTriangularDivisivel(23)); //Deve retornar 630
Console.WriteLine(MaiorNumeroTriangularDivisivel(167)); //Deve retornar 1385280
Console.WriteLine(MaiorNumeroTriangularDivisivel(374)); //Deve retornar 17907120
Console.WriteLine(MaiorNumeroTriangularDivisivel(500)); //Deve retornar 76576500

static int MaiorNumeroTriangularDivisivel(int n)
{
    int resultado = 0;
    int numeroTriangular = 0;

    for(int i = 1; resultado < n; i++)
    {
        numeroTriangular += i;
        int qntDivisores = QuantidadeFatores(numeroTriangular);

        if (qntDivisores >= n)
            resultado = numeroTriangular;
    }
    return resultado;
}

static int QuantidadeFatores(int numero)
{
    int qntFatores = 1;
    int fatorado = numero;
    int contador = 2;

    while(fatorado >= contador)
    {
        int expoente = 1;
        if(EhPrimo(contador))
        {
            while(fatorado % contador == 0)
            {
                fatorado /= contador;
                expoente++;
            }
            contador++;
        }
        else
        {
            contador++;
        }

        qntFatores *= expoente;

    }
    return qntFatores;
}

static bool EhPrimo (long numero)
{
    bool ehPrimo = false;
    if (numero <= 1)
        ehPrimo = false;

    else if (numero <= 3 || numero == 5 || numero == 7 || numero == 11 || numero == 13)
        ehPrimo = true;

    else if (numero % 2 == 0 || numero % 3 == 0 || numero % 5 == 0)
        ehPrimo = false;

    else
    {
        for (long i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                ehPrimo = false;
                break;
            }
            else
                ehPrimo = true;
        }
    }
    return ehPrimo;
}