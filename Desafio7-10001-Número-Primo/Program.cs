using System;

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

static int NthPrimo(int n)
{
    int[] numerosPrimos = new int[n];
    int nthPrimo = 0;
    int contador = 0;
    
    for(int i = 2; contador < n; i++)
    {
        if(EhPrimo(i))
        {
            numerosPrimos[contador] = i;
            contador++;
        }

        nthPrimo = numerosPrimos[n - 1];
    }

    return nthPrimo;
}

Console.WriteLine(NthPrimo(6)); //Deve retornar 13
Console.WriteLine(NthPrimo(10)); //Deve retornar 29
Console.WriteLine(NthPrimo(100)); //Deve retornar 541
Console.WriteLine(NthPrimo(1000)); //Deve retornar 7919
Console.WriteLine(NthPrimo(10001)); //Deve retornar 104743