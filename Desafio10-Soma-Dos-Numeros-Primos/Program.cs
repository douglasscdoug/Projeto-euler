using System;

Console.WriteLine(SomaNumerosPrimos(17)); //Deve retornar 41
Console.WriteLine(SomaNumerosPrimos(2001)); //Deve retornar 277050
Console.WriteLine(SomaNumerosPrimos(140759)); //Deve retornar 873608362
Console.WriteLine(SomaNumerosPrimos(2000000)); //Deve retornar 142913828922

static long SomaNumerosPrimos(int n)
{
    long resultado = 0;

    for(int i = 2; i < n; i++)
    {
        if(EhPrimo(i))
        {
            resultado += i;
        }
    }

    return resultado;
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
