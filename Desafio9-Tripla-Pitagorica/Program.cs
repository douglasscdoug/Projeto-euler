using System;

Console.WriteLine(TernoPitagoricoEspecial(24)); //Deve retornar 480
Console.WriteLine(TernoPitagoricoEspecial(120)); //Deve retornar 49920, 55080 ou 60000.
Console.WriteLine(TernoPitagoricoEspecial(1000)); //Deve retornar 31875000

static double TernoPitagoricoEspecial(int n)
{
    double resultado = 0;

    for(int a = 0; a < n; a++)
    {
        for(int b = 1; b <= n; b++)
        {
            double resultadoPotencia2 = Math.Pow((double)a, 2) + Math.Pow((double)b, 2);
            double c = Math.Sqrt(resultadoPotencia2);

            if(a + b + c == n)
            {
                resultado = a * b * c;
                break;
            }
        }

    }

    return resultado;
}