using System;

static int Mdc(int a, int b)
{
    while(a != 0)
    {
        int c = a;
        a = b % a;
        b = c;
    }
    return b;
}

static int Mmc(int a, int b)
{
    return a * (b / Mdc(a, b));
}

static int MenorMultiplo(int entrada)
{
    int resultado = 1;

    for(int i = 2; i <= entrada; i++)
    {
        resultado = Mmc(resultado, i);
    }
    return resultado;
}

Console.WriteLine(MenorMultiplo(5)); //Deve retornar 60
Console.WriteLine(MenorMultiplo(7)); //Deve retornar 420
Console.WriteLine(MenorMultiplo(10)); //Deve retornar 2520
Console.WriteLine(MenorMultiplo(13)); //Deve retornar 360360
Console.WriteLine(MenorMultiplo(20)); //Deve retornar 232792560