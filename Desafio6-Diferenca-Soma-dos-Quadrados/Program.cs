using System;

static double SomaQuadradosN(int n)
{
    double resultado = 0;

    for(int i = 1; i <= n; i++)
    {
        resultado += Math.Pow(i, 2);
    }

    return resultado;
}

static double QuadradoDaSomaN(int n)
{
    double resultado = 0;
    resultado = (n + 1) * (n / 2);
    return Math.Pow(resultado, 2);
}


static double DiferençaSomaQuadrados(int n)
{
    double resultado = QuadradoDaSomaN(n) - SomaQuadradosN(n);
    return resultado;
}

Console.WriteLine(DiferençaSomaQuadrados(10)); //Deve retornar 2640
Console.WriteLine(DiferençaSomaQuadrados(20)); //Deve retornar 41230
Console.WriteLine(DiferençaSomaQuadrados(100)); //Deve retornar 25164150