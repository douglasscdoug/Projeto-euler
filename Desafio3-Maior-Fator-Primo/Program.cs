using System;

//Valida se o número é primo e retorna um booleano.
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

/*Busca pelos fatores do número informado como parâmetro, valida se é o fator é primo
 e salva o maior fator primo como retorno.*/
static long MaiorFatorPrimo(long n)
{
    long maiorFatorPrimo = 0;
    long fatorado = n;
    long contador = 2;
    while (fatorado > 1)
    {
        if(fatorado % contador == 0)
        {
            if(EhPrimo(contador))
            {
                maiorFatorPrimo = contador;
                fatorado /= contador;
            }
            else
            {
                fatorado /= contador;
            }
        }
        contador++;
    }

    return maiorFatorPrimo;
}

Console.WriteLine(MaiorFatorPrimo(2)); //Deve retornar 2
Console.WriteLine(MaiorFatorPrimo(3)); //Deve retornar 3
Console.WriteLine(MaiorFatorPrimo(5)); //Deve retornar 5
Console.WriteLine(MaiorFatorPrimo(7)); //Deve retornar 7
Console.WriteLine(MaiorFatorPrimo(8)); //Deve retornar 2
Console.WriteLine(MaiorFatorPrimo(13195)); //Deve retornar 29
Console.WriteLine(MaiorFatorPrimo(600851475143)); //Deve retornar 6857